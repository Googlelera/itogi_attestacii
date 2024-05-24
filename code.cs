using System;

class MainClass {
    public static void Main (string[] args) {
        string[] originalArray = {"Hello", "2", "world", ":-)"};

        int count = 0;
        foreach (string str in originalArray) {
            if (str.Length <= 3) {
                count++;
            }
        }

        string[] newArray = new string[count];
        int newIndex = 0;
        foreach (string str in originalArray) {
            if (str.Length <= 3) {
                newArray[newIndex] = str;
                newIndex++;
            }
        }

        foreach (string str in newArray) {
            Console.Write(str + " ");
        }
    }
}