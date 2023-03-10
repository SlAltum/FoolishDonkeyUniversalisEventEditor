using System.Collections.Specialized;
using Internal;
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using FoolishDonkeyUniversalis;

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
            this.saveBtn = new System.Windows.Forms.Button();
            this.compileBtn = new System.Windows.Forms.Button();
            this.overviewBtn = new System.Windows.Forms.Button();
            this.namespaceNameLabel = new System.Windows.Forms.Label();
            this.namespaceName = new System.Windows.Forms.TextBox();
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.eventTitle = new System.Windows.Forms.TextBox();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.eventDesc = new System.Windows.Forms.TextBox();
            this.eventHiddenLabel = new System.Windows.Forms.Label();
            this.eventHidden = new System.Windows.Forms.CheckBox();
            this.countryEvent = new System.Windows.Forms.RadioButton();
            this.provinceEvent = new System.Windows.Forms.RadioButton();
            this.countryEventLabel = new System.Windows.Forms.Label();
            this.provinceEventLabel = new System.Windows.Forms.Label();
            this.eventTriggerLabel = new System.Windows.Forms.Label();
            this.eventTrigger = new System.Windows.Forms.TextBox();
            this.triggeredOnlyLabel = new System.Windows.Forms.Label();
            this.triggeredOnly = new System.Windows.Forms.CheckBox();
            this.fireOnlyOnceLabel = new System.Windows.Forms.Label();
            this.fireOnlyOnce = new System.Windows.Forms.CheckBox();
            this.mtthLabel = new System.Windows.Forms.Label();
            this.mtth = new System.Windows.Forms.TextBox();
            this.eventPictureLabel = new System.Windows.Forms.Label();
            this.eventPicture = new System.Windows.Forms.TextBox();
            this.immediateLabel = new System.Windows.Forms.Label();
            this.immediate = new System.Windows.Forms.TextBox();
            this.optionLabel = new System.Windows.Forms.Label();
            this.prevOptionBtn = new System.Windows.Forms.Button();
            this.nextOptionBtn = new System.Windows.Forms.Button();
            this.newOptionBtn = new System.Windows.Forms.Button();
            this.delOptionBtn = new System.Windows.Forms.Button();
            this.optionNameLabel = new System.Windows.Forms.Label();
            this.optionName = new System.Windows.Forms.TextBox();
            this.optionTriggerLabel = new System.Windows.Forms.Label();
            this.optionTrigger = new System.Windows.Forms.TextBox();
            this.optionEffectLabel = new System.Windows.Forms.Label();
            this.optionEffect = new System.Windows.Forms.TextBox();
            this.highlightLabel = new System.Windows.Forms.Label();
            this.highlight = new System.Windows.Forms.CheckBox();

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
            this.treeView1.AfterSelect += new TreeViewEventHandler(this.TreeViewAfterSelect); 
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
            this.addNamespaceBtn.Click += new System.EventHandler(this.AddNamespaceBtnClick);

            // 
            // addEventBtn
            // 
            this.addEventBtn.Location = new System.Drawing.Point(88, 476);
            this.addEventBtn.Name = "addNamespaceBtn";
            this.addEventBtn.Size = new System.Drawing.Size(80, 36);
            this.addEventBtn.Text = "添加事件";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.AddEventBtnClick);

            // 
            // delNodeBtn
            // 
            this.delNodeBtn.Location = new System.Drawing.Point(176, 476);
            this.delNodeBtn.Name = "addNamespaceBtn";
            this.delNodeBtn.Size = new System.Drawing.Size(80, 36);
            this.delNodeBtn.Text = "删除";
            this.delNodeBtn.UseVisualStyleBackColor = true;
            this.delNodeBtn.Click += new System.EventHandler(this.DelNodeBtnClick);

            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(880, 476);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 36);
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Save);

            // 
            // compileBtn
            // 
            this.compileBtn.Location = new System.Drawing.Point(880, 438);
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.Size = new System.Drawing.Size(80, 36);
            this.compileBtn.Text = "编译";
            this.compileBtn.UseVisualStyleBackColor = true;
            this.compileBtn.Click += new System.EventHandler(this.Compile);

            // 
            // overviewBtn
            // 
            this.overviewBtn.Location = new System.Drawing.Point(880, 0);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(80, 36);
            this.overviewBtn.Text = "预览";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.Overview);

            // 
            // namespaceNameLabel
            // 
            this.namespaceNameLabel.Location = new System.Drawing.Point(260, 4);
            this.namespaceNameLabel.Name = "namespaceNameLabel";
            this.namespaceNameLabel.Size = new System.Drawing.Size(68, 12);
            this.namespaceNameLabel.Text = "命名空间：";

            // 
            // namespaceName
            // 
            this.namespaceName.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.namespaceName.Location = new System.Drawing.Point(328, 0);
            this.namespaceName.Name = "namespaceName";
            this.namespaceName.Size = new System.Drawing.Size(200, 12);
            this.namespaceName.Text = "请输入命名空间";
            this.namespaceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.namespaceName.TextChanged += new System.EventHandler(this.NamespaceTextChanged);

            // 
            // eventTitleLabel
            // 
            this.eventTitleLabel.Location = new System.Drawing.Point(260, 24);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Size = new System.Drawing.Size(68, 12);
            this.eventTitleLabel.Text = "事件名称：";

            // 
            // eventTitle
            // 
            this.eventTitle.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eventTitle.Location = new System.Drawing.Point(328, 20);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(200, 12);
            this.eventTitle.Text = "请输入事件名称";
            this.eventTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eventTitle.TextChanged += new System.EventHandler(this.EventTitleTextChanged);

            // 
            // eventDescLabel
            // 
            this.eventDescLabel.Location = new System.Drawing.Point(260, 44);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(68, 12);
            this.eventDescLabel.Text = "事件描述：";

            // 
            // eventDesc
            // 
            this.eventDesc.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eventDesc.Location = new System.Drawing.Point(328, 40);
            this.eventDesc.Name = "eventDesc";
            this.eventDesc.Multiline = true;
            this.eventDesc.Size = new System.Drawing.Size(200, 150);
            this.eventDesc.Text = "请输入事件描述";
            this.eventDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eventDesc.TextChanged += new System.EventHandler(this.EventDescTextChanged);

            // 
            // eventHiddenLabel
            // 
            this.eventHiddenLabel.Location = new System.Drawing.Point(260, 198);
            this.eventHiddenLabel.Name = "eventHiddenLabel";
            this.eventHiddenLabel.Size = new System.Drawing.Size(72, 12);
            this.eventHiddenLabel.Text = "是否隐藏：";

            // 
            // eventHidden
            // 
            this.eventHidden.Location = new System.Drawing.Point(328, 194);
            this.eventHidden.Name = "eventHidden";
            this.eventHidden.Size = new System.Drawing.Size(20, 20);
            this.eventHidden.Checked = false;
            this.eventHidden.CheckedChanged += new System.EventHandler(this.EventHiddenCheckedChanged);

            // 
            // countryEventLabel
            // 
            this.countryEventLabel.Location = new System.Drawing.Point(360, 198);
            this.countryEventLabel.Name = "eventHiddenLabel";
            this.countryEventLabel.Size = new System.Drawing.Size(72, 12);
            this.countryEventLabel.Text = "国家事件";

            // 
            // countryEvent
            // 
            this.countryEvent.Location = new System.Drawing.Point(410, 194);
            this.countryEvent.Name = "countryEvent";
            this.countryEvent.Size = new System.Drawing.Size(20, 20);
            this.countryEvent.Checked = true;
            this.countryEvent.CheckedChanged += new System.EventHandler(this.EventTypeChanged);

            // 
            // provinceEventLabel
            // 
            this.provinceEventLabel.Location = new System.Drawing.Point(440, 198);
            this.provinceEventLabel.Name = "eventHiddenLabel";
            this.provinceEventLabel.Size = new System.Drawing.Size(72, 12);
            this.provinceEventLabel.Text = "省份事件";

            // 
            // provinceEvent
            // 
            this.provinceEvent.Location = new System.Drawing.Point(490, 194);
            this.provinceEvent.Name = "provinceEvent";
            this.provinceEvent.Size = new System.Drawing.Size(20, 20);
            this.provinceEvent.Checked = false;
            this.provinceEvent.CheckedChanged += new System.EventHandler(this.EventTypeChanged);
            
            // 
            // eventTriggerLabel
            // 
            this.eventTriggerLabel.Location = new System.Drawing.Point(260, 218);
            this.eventTriggerLabel.Name = "eventTriggerLabel";
            this.eventTriggerLabel.Size = new System.Drawing.Size(68, 12);
            this.eventTriggerLabel.Text = "触发条件：";

            // 
            // eventTrigger
            // 
            this.eventTrigger.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eventTrigger.Location = new System.Drawing.Point(328, 214);
            this.eventTrigger.Name = "eventTrigger";
            this.eventTrigger.Multiline = true;
            this.eventTrigger.Size = new System.Drawing.Size(200, 150);
            this.eventTrigger.Text = "请输入触发条件";
            this.eventTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eventTrigger.TextChanged += new System.EventHandler(this.EventTriggerTextChanged);
            
            // 
            // triggeredOnlyLabel
            // 
            this.triggeredOnlyLabel.Location = new System.Drawing.Point(260, 368);
            this.triggeredOnlyLabel.Name = "triggeredOnlyLabel";
            this.triggeredOnlyLabel.Size = new System.Drawing.Size(86, 12);
            this.triggeredOnlyLabel.Text = "triggeredOnly";

            // 
            // triggeredOnly
            // 
            this.triggeredOnly.Location = new System.Drawing.Point(350, 364);
            this.triggeredOnly.Name = "triggeredOnly";
            this.triggeredOnly.Size = new System.Drawing.Size(20, 20);
            this.triggeredOnly.Checked = true;
            this.triggeredOnly.CheckedChanged += new System.EventHandler(this.TriggeredOnlyCheckedChanged);
            
            // 
            // fireOnlyOnceLabel
            // 
            this.fireOnlyOnceLabel.Location = new System.Drawing.Point(260, 408);
            this.fireOnlyOnceLabel.Name = "fireOnlyOnceLabel";
            this.fireOnlyOnceLabel.Size = new System.Drawing.Size(68, 12);
            this.fireOnlyOnceLabel.Text = "只触发一次";

            // 
            // fireOnlyOnce
            // 
            this.fireOnlyOnce.Location = new System.Drawing.Point(328, 404);
            this.fireOnlyOnce.Name = "fireOnlyOnce";
            this.fireOnlyOnce.Size = new System.Drawing.Size(20, 20);
            this.fireOnlyOnce.Checked = false;
            this.fireOnlyOnce.CheckedChanged += new System.EventHandler(this.FireOnlyOnceCheckedChanged);
            
            // 
            // mtthLabel
            // 
            this.mtthLabel.Location = new System.Drawing.Point(380, 368);
            this.mtthLabel.Name = "mtthLabel";
            this.mtthLabel.Size = new System.Drawing.Size(48, 12);
            this.mtthLabel.Text = "mtth：";
            this.mtth.Enabled = false;

            // 
            // mtth
            // 
            this.mtth.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtth.Location = new System.Drawing.Point(430, 364);
            this.mtth.Name = "mtth";
            this.mtth.Size = new System.Drawing.Size(80, 12);
            this.mtth.Text = "请输入mtth";
            this.mtth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtth.TextChanged += new System.EventHandler(this.MtthTextChanged);

            // 
            // eventPictureLabel
            // 
            this.eventPictureLabel.Location = new System.Drawing.Point(260, 388);
            this.eventPictureLabel.Name = "eventPictureLabel";
            this.eventPictureLabel.Size = new System.Drawing.Size(68, 12);
            this.eventPictureLabel.Text = "事件图片：";

            // 
            // eventPicture
            // 
            this.eventPicture.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eventPicture.Location = new System.Drawing.Point(328, 384);
            this.eventPicture.Name = "eventPicture";
            this.eventPicture.Size = new System.Drawing.Size(200, 12);
            this.eventPicture.Text = "请输入图片名";
            this.eventPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eventPicture.TextChanged += new System.EventHandler(this.EventPictureTextChanged);

            // 
            // immediateLabel
            // 
            this.immediateLabel.Location = new System.Drawing.Point(530, 4);
            this.immediateLabel.Name = "immediateLabel";
            this.immediateLabel.Size = new System.Drawing.Size(68, 12);
            this.immediateLabel.Text = "立即效果：";

            // 
            // immediate
            // 
            this.immediate.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.immediate.Location = new System.Drawing.Point(598, 0);
            this.immediate.Name = "immediate";
            this.immediate.Multiline = true;
            this.immediate.Size = new System.Drawing.Size(200, 150);
            this.immediate.Text = "请输入立即效果";
            this.immediate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.immediate.TextChanged += new System.EventHandler(this.ImmediateTextChanged);
            
            // 
            // optionLabel
            // 
            this.optionLabel.Location = new System.Drawing.Point(530, 154);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(100, 12);
            this.optionLabel.Text = "选项1/共1个";

            // 
            // prevOptionBtn
            // 
            this.prevOptionBtn.Location = new System.Drawing.Point(632, 150);
            this.prevOptionBtn.Name = "prevOptionBtn";
            this.prevOptionBtn.Size = new System.Drawing.Size(20, 20);
            this.prevOptionBtn.Text = "<";
            this.prevOptionBtn.UseVisualStyleBackColor = true;
            this.prevOptionBtn.Click += new System.EventHandler(this.PrevOption);
            this.prevOptionBtn.Enabled = false;

            // 
            // nextOptionBtn
            // 
            this.nextOptionBtn.Location = new System.Drawing.Point(654, 150);
            this.nextOptionBtn.Name = "prevOptionBtn";
            this.nextOptionBtn.Size = new System.Drawing.Size(20, 20);
            this.nextOptionBtn.Text = ">";
            this.nextOptionBtn.UseVisualStyleBackColor = true;
            this.nextOptionBtn.Click += new System.EventHandler(this.NextOption);
            this.nextOptionBtn.Enabled = false;

            // 
            // newOptionBtn
            // 
            this.newOptionBtn.Location = new System.Drawing.Point(680, 150);
            this.newOptionBtn.Name = "newOptionBtn";
            this.newOptionBtn.Size = new System.Drawing.Size(50, 20);
            this.newOptionBtn.Text = "添加";
            this.newOptionBtn.UseVisualStyleBackColor = true;
            this.newOptionBtn.Click += new System.EventHandler(this.NewOption);

            // 
            // delOptionBtn
            // 
            this.delOptionBtn.Location = new System.Drawing.Point(732, 150);
            this.delOptionBtn.Name = "delOptionBtn";
            this.delOptionBtn.Size = new System.Drawing.Size(50, 20);
            this.delOptionBtn.Text = "删除";
            this.delOptionBtn.UseVisualStyleBackColor = true;
            this.delOptionBtn.Click += new System.EventHandler(this.DelOption);
            this.delOptionBtn.Enabled = false;
            
            // 
            // optionNameLabel
            // 
            this.optionNameLabel.Location = new System.Drawing.Point(530, 174);
            this.optionNameLabel.Name = "optionNameLabel";
            this.optionNameLabel.Size = new System.Drawing.Size(68, 12);
            this.optionNameLabel.Text = "选项名称：";

            // 
            // optionName
            // 
            this.optionName.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optionName.Location = new System.Drawing.Point(598, 170);
            this.optionName.Name = "optionName";
            this.optionName.Multiline = false;
            this.optionName.Size = new System.Drawing.Size(200, 20);
            this.optionName.Text = "请输入选项";
            this.optionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.optionName.TextChanged += new System.EventHandler(this.OptionNameTextChanged);
            
            // 
            // highlightLabel
            // 
            this.highlightLabel.Location = new System.Drawing.Point(822, 174);
            this.highlightLabel.Name = "highlightLabel";
            this.highlightLabel.Size = new System.Drawing.Size(30, 12);
            this.highlightLabel.Text = "高亮";

            // 
            // highlight
            // 
            this.highlight.Location = new System.Drawing.Point(800, 170);
            this.highlight.Name = "highlight";
            this.highlight.Size = new System.Drawing.Size(20, 20);
            this.highlight.Checked = false;
            this.highlight.CheckedChanged += new System.EventHandler(this.HighlightCheckedChanged);
            
            // 
            // optionTriggerLabel
            // 
            this.optionTriggerLabel.Location = new System.Drawing.Point(530, 194);
            this.optionTriggerLabel.Name = "optionTriggerLabel";
            this.optionTriggerLabel.Size = new System.Drawing.Size(68, 12);
            this.optionTriggerLabel.Text = "选项触发：";

            // 
            // optionTrigger
            // 
            this.optionTrigger.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optionTrigger.Location = new System.Drawing.Point(598, 190);
            this.optionTrigger.Name = "optionTrigger";
            this.optionTrigger.Multiline = true;
            this.optionTrigger.Size = new System.Drawing.Size(200, 150);
            this.optionTrigger.Text = "请输入触发条件";
            this.optionTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.optionTrigger.TextChanged += new System.EventHandler(this.OptionTriggerTextChanged);
            
            // 
            // optionEffectLabel
            // 
            this.optionEffectLabel.Location = new System.Drawing.Point(530, 344);
            this.optionEffectLabel.Name = "optionEffectLabel";
            this.optionEffectLabel.Size = new System.Drawing.Size(68, 12);
            this.optionEffectLabel.Text = "选项效果：";

            // 
            // optionEffect
            // 
            this.optionEffect.Font = new System.Drawing.Font("宋体", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optionEffect.Location = new System.Drawing.Point(598, 340);
            this.optionEffect.Name = "optionEffect";
            this.optionEffect.Multiline = true;
            this.optionEffect.Size = new System.Drawing.Size(200, 150);
            this.optionEffect.Text = "请输入选择后效果";
            this.optionEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.optionEffect.TextChanged += new System.EventHandler(this.OptionEffectTextChanged);

            // autoLoad
            this.Load += new System.EventHandler(this.FromLoad);
            this.FormClosing += new FormClosingEventHandler(this.SaveOrNot); 
            
            //
            // Form1
            //
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.addNamespaceBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.delNodeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.compileBtn);
            this.Controls.Add(this.overviewBtn);
            this.Controls.Add(this.namespaceNameLabel);
            this.Controls.Add(this.namespaceName);
            this.Controls.Add(this.eventTitleLabel);
            this.Controls.Add(this.eventTitle);
            this.Controls.Add(this.eventDescLabel);
            this.Controls.Add(this.eventDesc);
            this.Controls.Add(this.eventHiddenLabel);
            this.Controls.Add(this.eventHidden);
            this.Controls.Add(this.countryEvent);
            this.Controls.Add(this.provinceEvent);
            this.Controls.Add(this.countryEventLabel);
            this.Controls.Add(this.provinceEventLabel);
            this.Controls.Add(this.eventTriggerLabel);
            this.Controls.Add(this.eventTrigger);
            this.Controls.Add(this.triggeredOnlyLabel);
            this.Controls.Add(this.triggeredOnly);
            this.Controls.Add(this.fireOnlyOnceLabel);
            this.Controls.Add(this.fireOnlyOnce);
            this.Controls.Add(this.mtthLabel);
            this.Controls.Add(this.mtth);
            this.Controls.Add(this.eventPictureLabel);
            this.Controls.Add(this.eventPicture);
            this.Controls.Add(this.immediateLabel);
            this.Controls.Add(this.immediate);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.prevOptionBtn);
            this.Controls.Add(this.nextOptionBtn);
            this.Controls.Add(this.newOptionBtn);
            this.Controls.Add(this.delOptionBtn);
            this.Controls.Add(this.optionNameLabel);
            this.Controls.Add(this.optionName);
            this.Controls.Add(this.optionTriggerLabel);
            this.Controls.Add(this.optionTrigger);
            this.Controls.Add(this.optionEffectLabel);
            this.Controls.Add(this.optionEffect);
            this.Controls.Add(this.highlightLabel);
            this.Controls.Add(this.highlight);

            // 禁用tab
            this.label1.TabStop = false;
            this.treeView1.TabStop = false;
            this.addNamespaceBtn.TabStop = false;
            this.addEventBtn.TabStop = false;
            this.delNodeBtn.TabStop = false;
            this.saveBtn.TabStop = false;
            this.compileBtn.TabStop = false;
            this.overviewBtn.TabStop = false;
            this.namespaceNameLabel.TabStop = false;
            this.namespaceName.TabStop = false;
            this.eventTitleLabel.TabStop = false;
            this.eventTitle.TabStop = false;
            this.eventDescLabel.TabStop = false;
            this.eventDesc.TabStop = false;
            this.eventHidden.TabStop = false;
            this.countryEvent.TabStop = false;
            this.provinceEvent.TabStop = false;
            this.countryEventLabel.TabStop = false;
            this.provinceEventLabel.TabStop = false;
            this.eventTriggerLabel.TabStop = false;
            this.eventTrigger.TabStop = false;
            this.triggeredOnlyLabel.TabStop = false;
            this.triggeredOnly.TabStop = false;
            this.fireOnlyOnceLabel.TabStop = false;
            this.fireOnlyOnce.TabStop = false;
            this.mtthLabel.TabStop = false;
            this.mtth.TabStop = false;
            this.eventPictureLabel.TabStop = false;
            this.eventPicture.TabStop = false;
            this.immediateLabel.TabStop = false;
            this.immediate.TabStop = false;
            this.optionLabel.TabStop = false;
            this.prevOptionBtn.TabStop = false;
            this.nextOptionBtn.TabStop = false;
            this.newOptionBtn.TabStop = false;
            this.delOptionBtn.TabStop = false;
            this.optionNameLabel.TabStop = false;
            this.optionName.TabStop = false;
            this.optionTriggerLabel.TabStop = false;
            this.optionTrigger.TabStop = false;
            this.optionEffectLabel.TabStop = false;
            this.optionEffect.TabStop = false;
            this.highlightLabel.TabStop = false;
            this.highlight.TabStop = false;

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
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button compileBtn;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Label namespaceNameLabel;
        private System.Windows.Forms.TextBox namespaceName;
        private System.Windows.Forms.Label eventTitleLabel;
        private System.Windows.Forms.TextBox eventTitle;
        private System.Windows.Forms.Label eventDescLabel;
        private System.Windows.Forms.TextBox eventDesc;
        private System.Windows.Forms.Label eventHiddenLabel;
        private System.Windows.Forms.CheckBox eventHidden;
        private System.Windows.Forms.Label countryEventLabel;
        private System.Windows.Forms.RadioButton countryEvent;
        private System.Windows.Forms.Label provinceEventLabel;
        private System.Windows.Forms.RadioButton provinceEvent;
        private System.Windows.Forms.Label eventTriggerLabel;
        private System.Windows.Forms.TextBox eventTrigger;
        private System.Windows.Forms.Label triggeredOnlyLabel;
        private System.Windows.Forms.CheckBox triggeredOnly;
        private System.Windows.Forms.Label fireOnlyOnceLabel;
        private System.Windows.Forms.CheckBox fireOnlyOnce;
        private System.Windows.Forms.Label mtthLabel;
        private System.Windows.Forms.TextBox mtth;
        private System.Windows.Forms.Label eventPictureLabel;
        private System.Windows.Forms.TextBox eventPicture;
        private System.Windows.Forms.Label immediateLabel;
        private System.Windows.Forms.TextBox immediate;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Button prevOptionBtn;
        private System.Windows.Forms.Button nextOptionBtn;
        private System.Windows.Forms.Button newOptionBtn;
        private System.Windows.Forms.Button delOptionBtn;
        private System.Windows.Forms.Label optionNameLabel;
        private System.Windows.Forms.TextBox optionName;
        private System.Windows.Forms.Label optionTriggerLabel;
        private System.Windows.Forms.TextBox optionTrigger;
        private System.Windows.Forms.Label optionEffectLabel;
        private System.Windows.Forms.TextBox optionEffect;
        private System.Windows.Forms.Label highlightLabel;
        private System.Windows.Forms.CheckBox highlight;
    }
    public partial class MainWindow:Form{
        public MainWindow(){
            InitializeComponent();
        }
        private void AddNamespaceBtnClick(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("NewNamespace", 0, 1);
            this.treeView1.Nodes.Add(newNode);
            this.treeView1.Select();
            eventsData.namespaces.Add(new Namespace());
        }
        private void AddEventBtnClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            Console.WriteLine("[MainWindow] AddEventBtnClick: selectedNode.Name = {0}",selectedNode.Name);
            Console.WriteLine("[MainWindow] AddEventBtnClick: selectedNode.Text = {0}",selectedNode.Text);
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
                eventsData.namespaces[selectedNode.Index].events.Add(new CommonEvent());
            }else if(selectedNode.Level == 1){
                TreeNode newNode = new TreeNode("新事件", 2, 3);
                selectedNode.Parent.Nodes.Add(newNode);
                selectedNode.Parent.Expand();
                this.treeView1.Select();
                eventsData.namespaces[selectedNode.Parent.Index].events.Add(new CommonEvent());
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
            if (parentNode == null){
                eventsData.namespaces.RemoveAt(selectedNode.Index);
                this.treeView1.Nodes.Remove(selectedNode);
            }
            else{
                eventsData.namespaces[parentNode.Index].events.RemoveAt(selectedNode.Index);
                parentNode.Nodes.Remove(selectedNode);
            }
            this.treeView1.Select();
        }
        private void NamespaceTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个节点", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            TreeNode toRename;
            if (parentNode == null){
                toRename = selectedNode;
            }
            else{
                toRename = parentNode;
            }
            toRename.Text = eventsData.namespaces[toRename.Index].name = this.namespaceName.Text;
        }
        private void EventTitleTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            selectedNode.Text = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].title = this.eventTitle.Text;
        }
        private void EventDescTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].desc = this.eventDesc.Text;
        }
        private void EventTriggerTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].trigger = this.eventTrigger.Text;
        }
        private void ImmediateTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].immediate = this.immediate.Text;
        }
        private void OptionNameTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            int curOptionPtr = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr;
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options[curOptionPtr].name = this.optionName.Text;
        }
        private void HighlightCheckedChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            int curOptionPtr = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr;
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options[curOptionPtr].highlight = this.highlight.Checked;
        }
        private void OptionTriggerTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            int curOptionPtr = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr;
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options[curOptionPtr].trigger = this.optionTrigger.Text;
        }
        private void OptionEffectTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            int curOptionPtr = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr;
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options[curOptionPtr].effect = this.optionTrigger.Text;
        }
        private void EventPictureTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].eventPicture = this.eventPicture.Text;
        }
        private void EventHiddenCheckedChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].hidden = this.eventHidden.Checked;
            if(this.eventHidden.Checked){
                this.eventTitle.Enabled = false;
                this.eventDesc.Enabled = false;
                this.eventPicture.Enabled = false;
            }else{
                this.eventTitle.Enabled = true;
                this.eventDesc.Enabled = true;
                this.eventPicture.Enabled = true;
            }
        }
        private void TriggeredOnlyCheckedChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].triggeredOnly = this.triggeredOnly.Checked;
            if(this.triggeredOnly.Checked){
                this.mtth.Enabled = false;
            }else{
                this.mtth.Enabled = true;
            }
        }
        private void FireOnlyOnceCheckedChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].fireOnlyOnce = this.fireOnlyOnce.Checked;
        }
        private void MtthTextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            selectedNode.Text = eventsData.namespaces[parentNode.Index].events[selectedNode.Index].mtth = this.eventTitle.Text;
        }
        private void EventTypeChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            if(this.countryEvent.Checked){
                eventsData.namespaces[parentNode.Index].events[selectedNode.Index].eventType = CommonEvent.EventType.country_event;
            }else if(this.provinceEvent.Checked){
                eventsData.namespaces[parentNode.Index].events[selectedNode.Index].eventType = CommonEvent.EventType.province_event;
            }
        }
        private void PrevOption(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr --;
            UpdateVision(eventsData.namespaces[parentNode.Index].events[selectedNode.Index]);
        }
        private void NextOption(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr ++;
            UpdateVision(eventsData.namespaces[parentNode.Index].events[selectedNode.Index]);
        }
        private void NewOption(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options.Insert(eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr,new Option());
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr ++;
            UpdateVision(eventsData.namespaces[parentNode.Index].events[selectedNode.Index]);
        }
        private void DelOption(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if (parentNode == null){
                MessageBox.Show("请先选中一个事件", "提示信息");
                return;
            }
            else{
            }
            if(eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options.Count == 1){
                MessageBox.Show("请至少保留一个选项", "提示信息");
                return;
            }
            eventsData.namespaces[parentNode.Index].events[selectedNode.Index].options.RemoveAt(eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr);
            if(eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr != 0)
                eventsData.namespaces[parentNode.Index].events[selectedNode.Index].curOptionPtr --;
            UpdateVision(eventsData.namespaces[parentNode.Index].events[selectedNode.Index]);
        }
        private void UpdateVision(CommonEvent curEvent){
            int curOptionPtr = curEvent.curOptionPtr;
            int optionNum = curEvent.options.Count;
            if(curOptionPtr == 0){
                this.prevOptionBtn.Enabled = false;
            }else{
                this.prevOptionBtn.Enabled = true;
            }
            if(curOptionPtr == optionNum-1){
                this.nextOptionBtn.Enabled = false;
            }else{
                this.nextOptionBtn.Enabled = true;
            }
            if(optionNum == 1){
                this.delOptionBtn.Enabled = false;
            }else{
                this.delOptionBtn.Enabled = true;
            }
            this.optionLabel.Text = String.Format("选项{0}/共{1}个",curOptionPtr+1,optionNum);
            Option curOption = curEvent.options[curOptionPtr];
            this.optionName.Text = curOption.name;
            this.optionTrigger.Text = curOption.trigger;
            this.optionEffect.Text = curOption.effect;
            this.highlight.Checked = curOption.highlight;
        }
        private void FromLoad(object sender, EventArgs e)
        {
            this.treeView1.LabelEdit = false;
            string appPath = Application.StartupPath;
            if (!(Directory.Exists(appPath + "\\data")))
            {
                Directory.CreateDirectory(appPath + "\\data") ;
                eventsData = new EventsData();
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(Application.StartupPath + "\\data\\EventsData.bin", FileMode.Create,
                FileAccess.Write, FileShare.None);
                bf.Serialize(stream, eventsData);
                stream.Close();
            }
            EventsData2CreatTreeViewNode();//通过节点信息文件创建treeview节点树
            //treeview1全部展开
            this.treeView1.ExpandAll();
        }
        private void EventsData2CreatTreeViewNode()
        {
            Stream s = new FileStream(Application.StartupPath + "\\data\\EventsData.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            eventsData = (EventsData)bf.Deserialize(s);
            s.Close();
            int nameSpaceNum = eventsData.namespaces.Count;
            // create namespace
            for (int i=0;i<nameSpaceNum;i++){
                Namespace namespaceData = eventsData.namespaces[i];
                TreeNode newNamespace = new TreeNode(namespaceData.name, 0, 1);
                this.treeView1.Nodes.Add(newNamespace);
                int eventNum = namespaceData.events.Count;
                for (int j=0;j<eventNum;j++){
                    TreeNode newEvent = new TreeNode(namespaceData.events[i].title, 2, 3);
                    this.treeView1.Nodes[i].Nodes.Add(newEvent);
                }
            }
        }
        private void Save(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + "\\data\\EventsData.bin");
            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new FileStream(Application.StartupPath + "\\data\\EventsData.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);
            bf.Serialize(stream, eventsData);
            stream.Close();
        }
        private void Compile(object sender, EventArgs e){
            foreach(Namespace namespaceInfo in eventsData.namespaces){
                string eventFilePath = Application.StartupPath + eventsData.eventFilePath + "\\" + namespaceInfo.name + ".txt";
                string locFilePath = Application.StartupPath + eventsData.locFilePath + "\\" + namespaceInfo.name + "_l_english.yml";
                if (!(Directory.Exists(Application.StartupPath + "\\" + eventsData.eventFilePath)))
                    Directory.CreateDirectory(Application.StartupPath + "\\" + eventsData.eventFilePath);
                if (!(Directory.Exists(Application.StartupPath + "\\" + eventsData.locFilePath)))
                    Directory.CreateDirectory(Application.StartupPath + "\\" + eventsData.locFilePath);
                // compile event file
                using (StreamWriter compiler = new StreamWriter(eventFilePath, false, new UTF8Encoding(false))){
                    compiler.Write(String.Format("namespace = {0}\n",namespaceInfo.name));
                    int eventNum = namespaceInfo.events.Count;
                    for(int i=0;i<eventNum;i++){
                        CommonEvent commonEvent = namespaceInfo.events[i];
                        if(commonEvent.eventType == CommonEvent.EventType.country_event){
                            compiler.Write("country_event = {\n");
                        }else{
                            compiler.Write("province_event = {\n");
                        }
                        compiler.Write(String.Format("\tid = {0}.{1}\n",namespaceInfo.name,i+1));
                        if(commonEvent.hidden){
                            compiler.Write("\thidden = yes\n");
                        }else{
                            compiler.Write(String.Format("\ttitle = {0}.{1}t\n",namespaceInfo.name,i+1));
                            compiler.Write(String.Format("\tdesc = {0}.{1}d\n",namespaceInfo.name,i+1));
                            compiler.Write(String.Format("\tpicture = {0}\n",commonEvent.eventPicture));
                        }
                        if(commonEvent.fireOnlyOnce){
                            compiler.Write("\tfire_only_once = yes\n");
                        }
                        if(commonEvent.triggeredOnly){
                            compiler.Write("\tis_triggered_only = yes\n");
                        }else{
                            compiler.Write("\tmean_time_to_happen = {\n");
                            compiler.Write(String.Format("\t\tmonths = {0}\n",commonEvent.mtth));
                            compiler.Write("\t}\n");
                        }
                        compiler.Write("\ttrigger = {\n");
                        string[] eventTrigger = commonEvent.trigger.Split('\n');
                        foreach(string line in eventTrigger){
                            compiler.Write(String.Format("\t\t{0}\n",line));
                        }
                        compiler.Write("\t}\n");
                        compiler.Write("\timmediate = {\n");
                        string[] immediate = commonEvent.immediate.Split('\n');
                        foreach(string line in immediate){
                            compiler.Write(String.Format("\t\t{0}\n",line));
                        }
                        compiler.Write("\t}\n");
                        int optionNum = commonEvent.options.Count;
                        for(int j=0;j<optionNum;j++){
                            compiler.Write("\toption = {\n");
                            compiler.Write(String.Format("\t\tname = {0}.{1}.{2}\n",namespaceInfo.name,i+1,j+1));
                            if(commonEvent.options[j].highlight){
                                compiler.Write("\t\thighlight = yes\n");
                            }
                            compiler.Write("\t\ttrigger = {\n");
                            string[] optionTrigger = commonEvent.options[j].trigger.Split('\n');
                            foreach(string line in optionTrigger){
                                compiler.Write(String.Format("\t\t\t{0}\n",line));
                            }
                            compiler.Write("\t\t}\n");
                            string[] optionEffect = commonEvent.options[j].effect.Split('\n');
                            foreach(string line in optionEffect){
                                compiler.Write(String.Format("\t\t{0}\n",line));
                            }
                            compiler.Write("\t}\n");
                        }
                        compiler.Write("}\n");
                    }
                    compiler.Close();
                }
                // compile loc file
                using (StreamWriter locCompiler = new StreamWriter(locFilePath, false, new UTF8Encoding(true))){
                    locCompiler.Write("l_english:\n");
                    int eventNum = namespaceInfo.events.Count;
                    for(int i=0;i<eventNum;i++){
                        CommonEvent commonEvent = namespaceInfo.events[i];
                        locCompiler.Write(String.Format(" {0}.{1}t:0 \"{2}\"\n",namespaceInfo.name,i+1,commonEvent.title));
                        locCompiler.Write(String.Format(" {0}.{1}d:0 \"",namespaceInfo.name,i+1));
                        string[] eventDesc = commonEvent.desc.Split('\n');
                        foreach(string line in eventDesc){
                            locCompiler.Write(String.Format("{0}\\n",line));
                        }
                        locCompiler.Write("\"\n");
                        int optionNum = commonEvent.options.Count;
                        for(int j=0;j<optionNum;j++){
                            locCompiler.Write(String.Format(" {0}.{1}.{2}:0 \"",namespaceInfo.name,i+1,j+1));
                            locCompiler.Write(String.Format("{0}",commonEvent.options[j].name));
                            locCompiler.Write("\"\n");
                        }
                    }
                    locCompiler.Close();
                }
                // utf8-bom 2 utf8 again
                // string locStr;
                // using (StreamReader sr = new StreamReader(locFilePath, new UTF8Encoding(false))){
                //     locStr = sr.ReadToEnd();
                //     sr.Close();
                // }
                // Console.Write(locStr);
                // using (StreamWriter sw = new StreamWriter(locFilePath, false, new UTF8Encoding(true))){
                //     sw.Write(locStr);
                //     sw.Close();
                // }
            }
        }
        private void Overview(object sender, EventArgs e){
        }
        private void TreeViewAfterSelect(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            CommonEvent selectedEvent;
            if(selectedNode.Parent == null){
                this.namespaceName.Text = selectedNode.Text;
            }else{
                selectedEvent = eventsData.namespaces[selectedNode.Parent.Index].events[selectedNode.Index];
                Console.WriteLine("[MainWindow] TreeViewAfterSelect:selectedEvent.title={0}",selectedEvent.title);
                this.namespaceName.Text = selectedNode.Parent.Text;
                this.eventTitle.Text = selectedEvent.title;
                this.eventDesc.Text = selectedEvent.desc;
                this.eventHidden.Checked = selectedEvent.hidden;
                if(selectedEvent.eventType == CommonEvent.EventType.country_event){
                    this.countryEvent.Checked = true;
                    this.provinceEvent.Checked = false;
                }else if(selectedEvent.eventType == CommonEvent.EventType.province_event){
                    this.countryEvent.Checked = false;
                    this.provinceEvent.Checked = true;
                }
                this.eventTrigger.Text = selectedEvent.trigger;
                this.triggeredOnly.Checked = selectedEvent.triggeredOnly;
                this.fireOnlyOnce.Checked = selectedEvent.fireOnlyOnce;
                this.mtth.Text = selectedEvent.mtth;
                this.eventPicture.Text = selectedEvent.eventPicture;
                this.immediate.Text = selectedEvent.immediate;
                UpdateVision(selectedEvent);
            }
        }
        private void SaveOrNot(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("是否不保存就退出？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) //这里会出现一个弹窗。
            {
                this.FormClosing -= new FormClosingEventHandler(this.SaveOrNot); 
                Application.Exit();
            }

            else
            {
                e.Cancel = true;
            }
        }
        EventsData eventsData;
    }
    static class Boot{
        static void Main(){
            Application.Run(new MainWindow());
        }
    }
}