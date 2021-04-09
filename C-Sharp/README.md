# C#

## Table of Contents
## Data Structures

## Challenges
* [Where My Anagrams At](#Where-My-Anagrams-At)


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
