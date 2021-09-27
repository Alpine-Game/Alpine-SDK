using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Level_Editor {
    public partial class MainWindow : Form {
        public ItemManager itemManager { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            
        }

        private void sfmlBox2_Load(object sender, EventArgs e)
        {
            
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            
        }

        private void groupBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void entitySettingsPanel1_Load(object sender, EventArgs e)
        {
            
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            String newItemName = String.Format("New Item {0}", itemManager.items.Count);
            itemList.Items.Add(new ListViewItem(newItemName));

            Item newItem = new Item(newItemName, Paths.getImage("missing.png"), Item.ItemType.WORLD);
            itemManager.addItem(newItem);
        }

        UserControl tempEntitySettingPanel;
        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = itemList.Items[itemList.SelectedIndices[0]].Text;
                Item item = itemManager.items[selectedItem];
                Debug.WriteLine(selectedItem);
                itemManager.selectedItem = item;

                
                
                switch (item.itemType)
                {
                    case Item.ItemType.ENTITY:
                        tempEntitySettingPanel = new EntitySettingsPanel();
                        tempEntitySettingPanel.Location = new Point(9, 88);
                        panel2.Controls.Add(tempEntitySettingPanel);

                        tempEntitySettingPanel.Controls["textureBox"].Text = item.texturePath;
                        tempEntitySettingPanel.Controls["healthBox"].Text = "100";
                        break;
                    case Item.ItemType.WORLD:
                        tempEntitySettingPanel = new WorldItemSettingsPanel();
                        tempEntitySettingPanel.Location = new Point(9, 88);
                        panel2.Controls.Add(tempEntitySettingPanel);
                        
                        tempEntitySettingPanel.Controls["textureBox"].Text = item.texturePath;
                        break;
                    case Item.ItemType.TILEMAP:
                        break;
                    default:
                        Debug.WriteLine("No item selected.");
                        break;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine("uh oh someone did an oopsie poopsie!!");
            }
        }

        public void updateValue(object sender, EventArgs e)
        {
            
        }
    }
}