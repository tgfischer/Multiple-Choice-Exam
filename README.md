# Multiple Choice Exam Application
This is a C# console application that allows the user to input a text file full of multiple choice questions. The program will then iterate through each one, testing the user. This application randomizes the questions, and also randomizes the order of the choices so you don't memorize a pattern of answers

## How to use
Go to the ```Program.cs``` file, and change the string in line 15 to the path of the text file you want to use. Note that there are two text files provided with this project (```Multiple Choice/se3314.txt``` and ```Multiple Choice/se3351.txt```). An easy way to do this is drop the text file in the ```bin``` folder, and make the url the name of the text file 

### Example:
Put ```se3314.txt``` in your project's ```Multiple Choice/bin/Debug``` folder (assuming you are running your program in Debug mode), and make the url on line 15 of ```Program.cs```

```cs
String url = "se3314.txt";
```

## Text File Format
If you would like to write your own questions, the contents of the text file need to be in the following format

```
QUESTION:Some question
a)answer 1
b)answer 2
c)answer 3
...
z)answer n
ANSWER:Some answer
```

For the possible answers, it doesn't matter what letters you use. Just make use you have the parenthesis just before the start of the answer.

