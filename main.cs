using Internal;
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;

namespace FoolishDonkeyUniversalis
{
    partial class MainWindow
    {
        #region Windows Form Designer generated code
        private void InitializeComponent()

        {
            // Initialize window
            string imgsResourceFile = @".\imgs.resx";
            this.Size = new Size(960,540);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            string curIcoPath = Path.Combine(System.Environment.CurrentDirectory,String.Format("FDUEUtils{0}",Path.DirectorySeparatorChar),@"FoolishDonkey.ico");
            this.Icon = new Icon(curIcoPath);
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.addNamespaceBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.delNodeBtn = new System.Windows.Forms.Button();

            this.SuspendLayout();

            //

            // label1

            //

            this.label1.Location = new System.Drawing.Point(88, 0);

            this.label1.Name = "left-top";

            this.label1.Size = new System.Drawing.Size(70, 12);

            this.label1.Text = "事件树结构";


            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(256, 450);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            // System.Console.Write("Please press 'Enter' key to continue ... ");
            // System.Console.ReadLine();
            using (ResXResourceSet resxSet = new ResXResourceSet(imgsResourceFile)){
                this.imageList1.Images.Add((Image)resxSet.GetObject("CelestialEmporerCrown.png"));
                this.imageList1.Images.Add((Image)resxSet.GetObject("CelestialEmporerCrownSelected.png"));
                this.imageList1.Images.Add((Image)resxSet.GetObject("KingsCrown.png"));
                this.imageList1.Images.Add((Image)resxSet.GetObject("KingsCrownSelected.png"));
                this.imageList1.Images.SetKeyName(0, "CelestialEmporerCrown");
                this.imageList1.Images.SetKeyName(1, "CelestialEmporerCrownSelected");
                this.imageList1.Images.SetKeyName(2, "KingsCrown");
                this.imageList1.Images.SetKeyName(3, "KingsCrownSelected");
            }
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;

            // 
            // addNamespaceBtn
            // 
            this.addNamespaceBtn.Location = new System.Drawing.Point(0, 476);
            this.addNamespaceBtn.Name = "addNamespaceBtn";
            this.addNamespaceBtn.Size = new System.Drawing.Size(80, 36);
            this.addNamespaceBtn.Text = "添加命名空间";
            this.addNamespaceBtn.UseVisualStyleBackColor = true;
            this.treeView1.TabIndex = 1;
            this.addNamespaceBtn.Click += new System.EventHandler(this.AddNamespaceBtnClick);

            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(88, 476);
            this.addEventBtn.Name = "addNamespaceBtn";
            this.addEventBtn.Size = new System.Drawing.Size(80, 36);
            this.addEventBtn.Text = "添加事件";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.treeView1.TabIndex = 2;
            this.addEventBtn.Click += new System.EventHandler(this.AddEventBtnClick);

            // 
            // delNodeBtn
            // 
            this.delNodeBtn.Location = new System.Drawing.Point(176, 476);
            this.delNodeBtn.Name = "addNamespaceBtn";
            this.delNodeBtn.Size = new System.Drawing.Size(80, 36);
            this.delNodeBtn.Text = "删除";
            this.delNodeBtn.UseVisualStyleBackColor = true;
            this.treeView1.TabIndex = 3;
            this.delNodeBtn.Click += new System.EventHandler(this.DelNodeBtnClick);
            
            //
            // Form1
            //
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.addNamespaceBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.delNodeBtn);
            this.Name = "MainWindow";
            this.Text = "蠢驴风云事件编辑器";

            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addNamespaceBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button delNodeBtn;
    }
    public partial class MainWindow:Form{
        public MainWindow(){
            InitializeComponent();
        }
        private void AddNamespaceBtnClick(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("新命名空间", 0, 1);
            this.treeView1.Nodes.Add(newNode);
            this.treeView1.Select();
        }
        private void AddEventBtnClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            Console.WriteLine("[MainWindow] AddEventBtnClick: selectedNode.Name = {0}",selectedNode.Name);
            Console.WriteLine("[MainWindow] AddEventBtnClick: selectedNode.Level = {0}",selectedNode.Level);
            if (selectedNode == null){
                MessageBox.Show("请先选中一个命名空间", "提示信息");
                return;
            }
            if (selectedNode.Level == 0){
                TreeNode newNode = new TreeNode("新事件", 2, 3);
                selectedNode.Nodes.Add(newNode);
                selectedNode.Expand();
                this.treeView1.Select();
            }else if(selectedNode.Level == 1){
                TreeNode newNode = new TreeNode("新事件", 2, 3);
                selectedNode.Parent.Nodes.Add(newNode);
                selectedNode.Parent.Expand();
                this.treeView1.Select();
            }
        }
        private void DelNodeBtnClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("删除子节点前先选中一个节点", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (Parent == null)
                this.treeView1.Nodes.Remove(selectedNode);
            else
                parentNode.Nodes.Remove(selectedNode);
            this.treeView1.Select();
        }
    }
    static class Boot{
        static void Main(){
            Application.Run(new MainWindow());
        }
    }
}