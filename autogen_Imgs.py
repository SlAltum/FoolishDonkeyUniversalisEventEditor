import os
input_path = os.path.join(os.path.dirname(__file__),'FDUEUtils','logo')
output_path = os.path.join(os.path.dirname(__file__),'Imgs.cs')
file_name_list = os.listdir(input_path)

with open(output_path,'w',encoding='utf-8') as fs:
    fs.write('using System.Net.Mime;\n')
    fs.write('using System;\n')
    fs.write('using System.Drawing;\n')
    fs.write('using System.Drawing.Imaging;\n')
    fs.write('using System.IO;\n')
    fs.write('using System.Resources;\n')
    fs.write('public class Imgs{\n')
    fs.write('\tpublic static void Main(){\n')
    fs.write('\t\tusing (ResXResourceWriter resx = new ResXResourceWriter(@".\imgs.resx")){\n')
    for file_name in file_name_list:
        fs.write('\t\t\tresx.AddResource("%s", Image.FromFile(@".\FDUEUtils\logo\%s"));\n'%(file_name,file_name))
    fs.write('\t\t}\n')
    fs.write('\t}\n')
    fs.write('}\n')