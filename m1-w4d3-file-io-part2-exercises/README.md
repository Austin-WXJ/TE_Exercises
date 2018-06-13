# File I/O Part 2 Exercises

## FizzWriter

Create a program to write out the result of FizzBuzz (1 to 300) to a file called `FizzBuzz.txt`.

* If the number is divisible by 3 or contains a 3, print “Fizz”
* If the number is divisible by 5 or contains a 5, print “Buzz”
* If the number is divisible by 3 and 5, print “FizzBuzz”
* Otherwise print the number.

## File Splitter (Challenge)

Develop an application that takes a significantly large input file and splits it into smaller file chunks.

In order to determine how many files need to be produced, ask the user for the maximum amount of lines that
should appear in each output file.

```
What is the name of the input file? input.txt
How many lines of text (max) should there be in the split files? 100
The input file had 1030 lines of text.

Each file that is created should have a sequential number assigned to it.

For a 1030 line input file "input.txt" this will produce 11 output files

**GENERATING OUTPUT**

Generating input-1.txt
Generating input-2.txt
Generating input-3.txt
Generating input-4.txt
Generating input-5.txt
Generating input-6.txt
Generating input-7.txt
Generating input-8.txt
Generating input-9.txt
Generating input-10.txt
Generating input-11.txt

```


These types of files use to be used quite common back in the earlier days of computing when disks such as floppies were much smaller and couldn’t hold a larger program on their own.