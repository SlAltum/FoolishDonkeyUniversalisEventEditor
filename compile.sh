python autogen_Imgs.py
csc Imgs.cs
./Imgs.exe
csc main.cs CommonEvent.cs
read -n 1 -p "Press any key to continue..." INP
if [ $INP != '' ] ; then
        echo -ne '\b \n'
fi