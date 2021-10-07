using System;
using System.Collections.Generic;
using SFML.Graphics;

namespace Level_Editor.engine.entity
{
    public class EntityManager {
        public Dictionary<String, Entity> _entities;

        public EntityManager(){
            _entities = new Dictionary<string, Entity>();
        }

        public void create() {
        }

        public void update(RenderWindow window) {
            for (int i = 0; i < getEntities().Count; i++) {
                window.Draw(getEntities()[i].entitySprite);
            }
        }

        public void addEntity(Entity entity) {
            entity.create();
            _entities.Add(entity.name, entity);
        }

        public void removeEntity(String name) {
            _entities[name].dispose();
            _entities.Remove(name);
        }

        public List<Entity> getEntities() {
            List<Entity> list = new List<Entity>();

            foreach (String s in _entities.Keys) {
                list.Add(_entities[s]);
            }

            return list;
        }

        ~EntityManager()
        {
            foreach (Entity entity in getEntities())
            {
                entity.dispose();
                _entities.Remove(entity.name);
            }
        }
    }
}