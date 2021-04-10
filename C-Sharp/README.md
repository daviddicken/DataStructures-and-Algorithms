# C#

## Table of Contents
## Data Structures

## Challenges
* [Where My Anagrams At](#Where-My-Anagrams-At)
* [Verifying An Alien Dictionary](#Verifying-An-Alien-Dictionary)


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
