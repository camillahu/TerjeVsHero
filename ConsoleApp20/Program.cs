using ConsoleApp20;

string[] asciiArt = new string[]
            {
                "XXXXXXXXXXXXXXXXXXXXXXXXXXKOkxdoodddxxkO0KKXXXXKKKKKKKKKKXXXXXXXXNXXXKK00KKOddOKXXXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXKOOkkxxxkOO00KKKKKKKKKK000KKKKKXXXXXXXNNNNXXKKKXXXOolxKXXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXKK0OkkkO000KKKKKKKKK00000000KKKXXXXXXXXNNNNXXXKXXXXOcckKXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXKK0OkkO000KK0KKKK00000OOOOO000KKXXXXXXXNNNNNNNNXXXNXd:ckXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXKKOOkkO00KKK0000000OOOOOOOOOO00KKXXXXXXXXXNNNNNNXXXNOc;lOXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXKOO0OxxkO0KKKKKKK000000OOOOOOOOOO0KKKKKKKKKKXXXXXXXXXXKxccxKXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXX0xx0OxkkddkO0KKKKKKKK0000000000000000KKKKKKKKKKKKKKKXXXXXXOold0XXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXkokOxdxxdxkO0KKKKKKKKK00000000000000KKXXXKKKKKKKXKKKKKKKKKKkoollllllllloooooooo",
                "XXXXXXXXXXXXXXXXXXXXKOkkxddkkkOO0KKKKK000000OOOOO000OOOOOO0KKXKKXXXXKXXKKKKKKKXXOxl;,,'''''''''''''',",
                "XXXXXXXXXXXXXXXXXXXXXKkdolco0K00KXKKK0OOOOOkxxdddooooddxxxkkO0O000KKXXXKKKKKKKKKOxoccccccc::::::::::",
                "XXXXXXXXXXXXXXXXXXXXXKxlcccxXNXXXXKK0Okxxdol:;;,',;;;:cclodxkOOOkOOO00KKKXXKKKK0xdoodddddoddddddxddo",
                "XXXXXXXXXXXXXXXXXXXKXXOdooxXWNNNXXKK0Okxxdoccc:;,;cc;',;:coxkOOkkkkkkkO0KKXXXK0dlccccllllllloooooooo",
                "XXXXXXXXXXXXXXXKXXKKXXK00xkXWNNXXXXXK0OOOOkxdoooooooc::ccldOKK0kocc::cldxO0KXKkdooooooolllllcccccccc",
                "XXXXXKKKKXXXXKKKKKXKXXK0OOKNNNNXXNXXK00000000OkxxxxxxxxddxOKXXKo,''..,,;coxO00kkOOOOOOOOkkkkkkkkkkkk",
                "XXKKKKKKKKKKXXKKKKKKXKK0OOXNXXXXNNXKKKKKKKKKKKKKKK000OOkkO0KXXKkl::::cc;,cdk0OOOOOOOOOOOOOOOOOOOOOOO",
                "KKKKKKKKKKKKKKKKKKKKKXXKO0XXXXXNNXXKKKK000KKKKKKKK00OOOO000KXXK0Odllodxdook00Okxxxxxxxxxxxxxkkkkkkkk",
                "KKKKKKKKKKKKKKXKKKKKXNNNXNNXXNNXXXKKK00OO000000OkxdoodxO00KXXXXKKK0OkkO00000kkkooddodddddddddxxxxxxx",
                "KKKKKKKKKKKXXKOkxkkOXNNNNNXXXXXKKK00OkkxxxxxxdolccldkOO000KXXX0O0KXXXXXKKKKOxkx::o:,;;:;;::;;;;;::::",
                "KKKKKKKKKXXNX0l..'c0NXXNNXXKXXXKK0OkxxddddolllclllodxxkOO00KXK0dokKXXXXXXK0kkkdc::;;;;;,,,,,,'',,,,,",
                "KKKKKKKXNNNXKOc..,kNNXXNXKKKXXKK00kxdddddlccloodoollcclodxxOOO0x:lx0KXXXXKOkkkxdddddoooooooolllllccc",
                "XXXXKXNNNXKK00o..;OXXXXXXK0KKKK0Okxdddxxxolcclddxddolcc:cclooxOx::okO0KKKOkxxxxxxxxxxxkkkkOOOOOOOOOO",
                "KKK0O0KXXKK000O:.,kXXKKKK0O0KXK0Okxdxxxxxdol:,';:loolllllodxOO0ko:cdkO000kkkkkxkkxxxxxxxxxkkkOOOOOOO",
                "0KK0OO0K000OOOOd..dKK00000OO0KK0kxddddxxxxxxxoc;,,;;;;:lllodkkkkxcldkOOOOkkkkkxxkkkkkkkkkkOOOOOOOOOO",
                "0000OOOO0OOOOOOkc.cO0OO00OOOOKK0kxddoddkkkkkkkkxdollcccc::;;:ldxxddxkOOOkkkkkkxxxxkkkkkkkkkkkkkkkkkk",
                "OOOO00OOOOkkOOkOx,.oOkkkOkkkkO00kxddddxkOOOkkkkkxxdddxxxkOOOOOOOOOOOOOkkkkkkkkxxxxkkkkkkkkkkkkkkkkkk",
                "kkOOOOOOkkkkkkkkko..lkxxkkxxxkOOkxddddxkkOOOOOkkxxxxxxxxO000KK00OOOkkkkxkkkkkkxxxxkkkkkkkkkkkkkkkOOO",
                "kkkkOOOOkxkkkkkkkxl..cxxxxxddxkkkxddddxxkkO000000000000OO000000OkkkkxxxxkkkkkkxxxxxxkkkkkkkkkkkkOOOO",
                "kkkkkkOOOkxkkkxkkxx:..;oddddddxxxxxddddxxxxkO000KKKKKXXKKKKK0OOkxkOkxxxxkkkkkkxxxkkkkxxxxxxkkkkxxkOO"
            };

foreach (string line in asciiArt)
{
    Console.WriteLine(line);
}
App.Run();
