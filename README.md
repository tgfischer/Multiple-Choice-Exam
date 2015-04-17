# Multiple Choice Exam Application
This is a C# console application that allows the user to input a text file full of multiple choice questions. The program will then iterate through each one, testing the user

## How to use
Go to the ```Program.cs``` file, and change the string in line 15 to the path of the text file you want to use. Note that there are two text files provided with this project (```Multiple Choice/se3314.txt``` and ```Multiple Choice/se3351.txt```)

## Text File Format
The contents of the text file need to be in the following format

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

