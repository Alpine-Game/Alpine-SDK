using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ThreadState = System.Diagnostics.ThreadState;

namespace Level_Editor {
    public partial class MainWindow : Form {
        public ItemManager itemManager { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            foreach (string name in Enum.GetNames(typeof(Item.ItemType)))
            {
                selectedItemType.Items.Add(name);
            }

            selectedItemType.SelectedIndex = 0;

            selectedItemType.Visible = false;
            nameBox.Visible = false;
            nameLabel.Visible = false;
            typeLabel.Visible = false;

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

                nameLabel.Visible = true;
                typeLabel.Visible = true;

                nameBox.Text = item.itemName;
                selectedItemType.SelectedItem = item.itemType.ToString();

                nameBox.Visible = true;
                selectedItemType.Visible = true;
                
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

        private void selectedItemType_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((o =>
            {
                new GameState(args:"");
            }));
            
            thread.Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
        }

        private void compileWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // not added
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutEngine window = new AboutEngine();
            window.Show();
        }
    }
}