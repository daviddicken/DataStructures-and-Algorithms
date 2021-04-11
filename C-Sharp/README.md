# C#

## Table of Contents
## Data Structures
* [Linked List](#Linked-List)

## Sorts\ing Algorithms

## Challenges
* [Where My Anagrams At](#Where-My-Anagrams-At)
* [Verifying An Alien Dictionary](#Verifying-An-Alien-Dictionary)

# Data Structures
## Linked List
A Linked List is a list of node that hold a value and a pointer to the next node in the list. The only thing a Linked list knows about is it's head node.

## Append
The Append method takes in a value and creates a new node to hold that value. It then iterates through the linked list until the next node is null. And istead of the next node pointing to null append will now point it to the new node that was created.

![](whiteboards/append.png)

## Insert
To insert a node into a linked list we need to pass a value into the Insert function and then create a new node with that value. We will then point the new nodes next to the head node. And finally we reasign the new node as the head node.

## InsertBefore
InsertBefore takes in a value and a search value. It searches the list for the search value and if the search value is found a new node  holding the other value will be created and inserted before the node that holds the search value. The node that was pointing to the node holding the search value will now point to the new node. The new node will now point to the node holding the search value's next. And the node holding the search value will now have a pointer pointing to the next node.

![](whiteboards/insert_before.png)

## InsertAfter 
InsertAfter takes in a value and a search value. It then iterates through the linked list comparing each value to the search value. If the values are equal a new node is created to hold the other value that was passed in. That new node will be inserted into the linked list after the node that holds the value matching the search value. The new nodes next will now point to the node holding the search values's next.

![](whiteboards/insertafter.pdf)

## Includes
To check a linked list if it contains a value we need to step through every node comparing the values until the value is found or the end of the linked list is reached.
We can do this by putting the head node into a variable and writing a while loop that runs until node is equal to null. Inside the loop we will compare the value passed in to the current nodes value if they match we will return true. If not we make the current node equal to the current nodes next node.
If the while loop exits then the value was not found and we return false.

## Print
The print method print human readable representation of the lists values to the screen. We do that a lot like the Includes method except in the while loop we console.write a pretty string with the curent nodes value and when the loop is exited we print out null

## ToString
ToString is a method used to return a human readable string representation of the values in the list. We do this recursively by creating a class level string variable to hold our string as we step back through the stack. We then make sure that the string is empty in the main toString and we call a overloaded helper toString method that taked in a node, by passing in the head node. In the helper method we check that the node is not null if it is we add "NULL" to the string and return it. If it's not null we add the value of that node to our string and then we call the helper method again passing in the current node next.
_____________

# Challenges

## Wheres My Anagrams At
Date: 4/8/2021  
Site: Codewars  

### Challenge 
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none.

### Algorithm
* Create a list to be returned.
* Put each char of word to be checked against array of words into a Dictionary with the char as the key and the number of times the char is seen in word as the value.
* Set a flag (boolean) that will be flipped to false when a word being check is found not to be an anagram.
* Iterate through array of words and create a Dictionary for each word simular to the Dictionary made in step 2 with char as key and times seen as value.
* While creating Dictionary check if each char exist in 1st Dictionary, if char is not found in 1st Dictionary flip flag to false and move to next word.
* After 2nd Dictionary has been created compare count of both Dictionaries if different flip flag to false and move on to next word.
* Iterate through each letter(char) in word from word array and compare the value found at that key in both Dictionaries if different flip flag to false and move on to next       word.
* If flag is still true add current word from word array to return list.
* When all words from word array have been compared return list.
__________
## Verifying An Alien Dictionary
Date: 4/9/2021  
Site: LeetCode

### Challenge
In an alien language, surprisingly they also use english lowercase letters, but possibly in a different order.
The order of the alphabet is some permutation of lowercase letters.

Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if
the given words are sorted lexicographicaly in this alien language.

### Algorithm
* Iterate through words in word array comparing two words at a time
* Step through each letter in the words comparing them until the letter being compared in each word is different or the end of one of the words is found
* If all letters are the same and the end of the second word is found return false
* If two different letters are found check the index of location of each letter in the order. 
* If index of for letter from second word is less then index of for letter from first word return false
* If all words in array have been compared and false wasn't returned then return true
______________
