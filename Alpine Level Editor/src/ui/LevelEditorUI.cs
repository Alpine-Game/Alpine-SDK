using System;
using System.Collections.Generic;
using Alpine_Level_Editor.entities;
using Alpine_Level_Editor.utils;
using SFML.Graphics;
using SFML.System;
using TGUI;

namespace Alpine_Level_Editor.ui {
    public class LevelEditorUI : AlpineUI {
        private DragableEntity entity;
        private EntityManager entityManager;
        
        public LevelEditorUI(RenderWindow window, EntityManager entityManager) : base(window) {
            this.getGUI().LoadWidgetsFromFile("res/AlpineUI.uilayout");
            this.entityManager = entityManager;

            #region ButtonHandlers
                addEntity();
                
            #endregion
            
            
        }

        public override void render() {
            /*
            if (entity != null) {
                getGUI().Target.Draw(entity.entitySprite);
            }
            */
            
        } //Don't need this.

        public void addEntity() { //Handles entity adding.
            Panel entityPanel = (Panel) this.getGUI().Widgets[getWidgets()["newEntityPanel"]];
            Button addEntity = (Button) entityPanel.Widgets[AlpineCollections.getWidgetsFromPanel(entityPanel)["addEntity"]];
            
            addEntity.Clicked += (sender, e) => {
                entity = new DragableEntity("testEntity", 100, "res/yes.png", getGUI().Target);
                entityManager.addEntity(entity);
                
                entity.entitySprite.Position = new Vector2f(0f, 0f);
                Console.WriteLine(entityManager.getEntities()[0].name);
            };
        }
    }
}