# 蠢驴风云可视化事件编辑器使用说明
这只是个辅助工具，而且功能并不完整，各位看着用就好了。
## 如何开始
把main.exe和imgs.resx两个文件复制到你的mod根目录下面，然后直接打开main.exe编辑各种事件，编辑完成以后点击右下角的"编译"按钮就会自动生成事件的txt文件以及yml文件。
注意生成的yml文件是不能直接用的，要扔到paratranz之类的网站里面进行转码。
## 如果我想要修改文件输出路径怎么办
在CommenEvent.cs文件的EventsData类下面，eventFilePath是txt文件输出路径，locFilePath是yml文件输出路径。修改完了以后运行compile.sh，记得先把编辑器关掉，不然它编译不起来。
## 退出之前记得点右下角的保存按钮