# File I/O Part 1 Exercises

## WordSearch

### Part 1

Write a program that asks the user for a search string and a filesystem path for a text file. When executing it searches the file for occurrences of the search string and each time it finds the search string, displays the line number and contents of the line it was found in on the console. 

As a special treat, and a break from arrays, line numbers begin with 1.

Use `alices_adventures_in_wonderland.txt` for test input. 

If the user were to search the text for the string 'Alice' the initial output should start with:
```
1) Project Gutenberg's Alice's Adventures in Wonderland, by Lewis Carroll
9) Title: Alice's Adventures in Wonderland
43) [Illustration: "Alice"]
```

### Part 2

Modify the program to ask the user if the search should be case insensitive.

Use `alices_adventures_in_wonderland.txt` for test input.
       
If the user were to search the text for the string 'Alice' the initial output should start with:
```
1) Project Gutenberg's Alice's Adventures in Wonderland, by Lewis Carroll
9) Title: Alice's Adventures in Wonderland
41) ALICE'S ADVENTURES IN WONDERLAND
43) [Illustration: "Alice"]
```

<div style="page-break-after: always;"></div>

## QuizMaker (Challenge)

Create a quiz maker program which asks the user a question. They should be presented with the possible multiple choice answers and allowed to specify the correct answer.

The program should read the questions from an input file during startup. The questions and answers in the file will be pipe delimited | and correct answers will be marked with an asterisk in the file.

```
Question-1|answer-1|answer-2|correct-answer*|answer-4
```

Example file

```
What color is the sky?|Yellow|Blue*|Green|Red
What are Cleveland's odds of winning a championship?|Not likely*|Highly likely|Fat chance|Who cares??
```

**Tips**

* Create a class that can hold a quiz question, its available answers, and the correct answer.
* Try holding each quiz question in a list of quiz questions

### Step 1

Ask a single question to the user when the application is opened. Don't show the asterisk in the list of choices.

Example
```
What color is the sky?
1. Yellow
2. Blue
3. Green
4. Red

Your answer: 2

Sorry that isn't correct!
``` 

### Step 2

Go through all of the available quiz questions and ask the user each one sequentially. Record how many answers they got correct and print out the total at the end.

Example
```
What color is the sky?
1. Yellow
2. Blue
3. Green
4. Red

Your answer: 2

Sorry that isn't correct!

What are the Cleveland Browns' odds of winning a championship?
1. Not likely
2. Highly likely
3. Fat chance
4. Who cares??

Your answer: 1

RIGHT!

You got 1 answer(s) correct out of the total 2 questions asked
```