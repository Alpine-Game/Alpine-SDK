using System;
using System.Collections.Generic;
using Level_Editor.engine.entity;
using Level_Editor.engine.util;
using SFML.Graphics;

namespace Level_Editor.engine.scene
{
    public class Scene
    {
        public RenderWindow window;
        
        public Dictionary<String, GameObject> sceneObjects;
        
        public EntityManager entityManager;


        public Scene(RenderWindow window)
        {
            this.window = window;
            sceneObjects = new Dictionary<string, GameObject>();
            entityManager = new EntityManager();
        }

        public virtual void update()
        {
            foreach (GameObject gameObject in sceneObjects.Values)
            {
                gameObject.update();
            }
        }

        public virtual void render()
        {
            foreach (GameObject gameObject in sceneObjects.Values)
            {
                gameObject.render();
            }
            
            entityManager.update(window);
        }

        public void unload()
        {
            foreach (GameObject gameObject in sceneObjects.Values)
            {
                gameObject.dispose();
            }
        }
    }
}