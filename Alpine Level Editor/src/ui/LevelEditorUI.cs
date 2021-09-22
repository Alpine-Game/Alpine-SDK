using System;
using System.Collections.Generic;
using Alpine_Level_Editor.entities;
using Alpine_Level_Editor.utils;
using Alpine_Level_Editor.utils.entity_utils;
using Newtonsoft.Json;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using TGUI;

namespace Alpine_Level_Editor.ui {
    public class LevelEditorUI : AlpineUI {
        private EntityManager entityManager;

        private RenderWindow window;

        private Panel entityPanel;
        private Panel newEntityPanel;
        private Panel worldPanel;
        private Button updateDataButton;
        private TextBox dataTextBox;
        private Button addEntityButton;
        
        public LevelEditorUI(RenderWindow window, EntityManager entityManager) : base(window) {
            this.getGUI().LoadWidgetsFromFile("res/AlpineUI.uilayout");
            this.entityManager = entityManager;
            this.window = getGUI().Target;
            
            entityPanel = (Panel)getGUI().Widgets[getWidgets()["entityPanel"]];
            worldPanel = (Panel)getGUI().Widgets[getWidgets()["worldPanel"]];
            newEntityPanel = (Panel)getGUI().Widgets[getWidgets()["newEntityPanel"]];
            updateDataButton = (Button)entityPanel.Widgets[AlpineCollections.getWidgetsFromPanel(entityPanel)["updateData"]];
            dataTextBox = (TextBox)entityPanel.Widgets[AlpineCollections.getWidgetsFromPanel(entityPanel)["newDataBox"]];
            addEntityButton = (Button) newEntityPanel.Widgets[AlpineCollections.getWidgetsFromPanel(newEntityPanel)["addEntity"]];

            #region ButtonHandlers
                addEntity();
                updateEntityData();
            #endregion
        }

        public override void render() {
            Vector2f mousePosition = new Vector2f(0, 0);
            mousePosition = window.MapPixelToCoords(new Vector2i(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y));

            mousePosition.X = mousePosition.X + window.GetView().Center.X - (window.GetView().Size.X / 2) + 1;
            mousePosition.Y = mousePosition.Y + window.GetView().Center.Y - (window.GetView().Size.Y / 2);
            
            FloatRect mousePos = new FloatRect();

            mousePos.Left = mousePosition.X;
            mousePos.Top = mousePosition.Y;
            mousePos.Width = 4;
            mousePos.Height = 4;

            try {
                if (Mouse.IsButtonPressed(Mouse.Button.Left)) {
                    foreach (Entity e in entityManager.getEntities()) {
                        DragableEntity dragEntity = (DragableEntity)e;

                        if (mousePos.Intersects(dragEntity.getHitbox())) {
                            entityManager.selectedEntity = dragEntity;

                            dataTextBox.Text = JsonConvert.SerializeObject(e.entityData);

                            Console.WriteLine("A");

                            break;
                        }
                        else {
                            if (getGUI().GetWidgetBelowMouseCursor((int) mousePosition.X, (int) mousePosition.Y) == null) {
                                entityManager.selectedEntity = null;
                                dataTextBox.Text = "";
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException ex) {
            }

            if (entityManager.selectedEntity == null) {
                entityPanel.Visible = false;
                entityPanel.Enabled = false;
                worldPanel.Visible = true;
                worldPanel.Enabled = true;
            }
            else {
                entityPanel.Visible = true;
                entityPanel.Enabled = true;
                worldPanel.Visible = false;
                worldPanel.Enabled = false;
            }
        }

        public void addEntity() { //Handles entity adding.
            Panel entityPanel = (Panel) this.getGUI().Widgets[getWidgets()["newEntityPanel"]];

            addEntityButton.Clicked += (sender, e) => {
                DragableEntity entity = new DragableEntity("New Entity " + entityManager._entities.Values.Count, 100, "res/yes.png", getGUI().Target, this);
                entityManager.addEntity(entity);
                
                entity.entitySprite.Position = new Vector2f(10f, 10f);
            };
        }

        public void updateEntityData() { //Update the entity data.
            updateDataButton.Clicked += (sender, e) => {
                    String boxContents = dataTextBox.Text;
                    EntityData newData = JsonConvert.DeserializeObject<EntityData>(boxContents);
                    
                    try {
                        entityManager.selectedEntity.entityData = newData;
                        
                        entityManager.selectedEntity.name = newData.name;
                        entityManager.selectedEntity.health = newData.health;
                        entityManager.selectedEntity.entitySprite.Texture = new Texture(newData.texLoc);
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Tried to update sprite with invalid data.");
                        Console.WriteLine(ex);
                        Console.WriteLine("This basically means the entity was invalid, disregard this.");
                    }
                };
            }
        }
    }