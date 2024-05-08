# Grand Circus Deliverable 2 Task - Coin Flip Challenge

## Description

Write a program that asks the user their name and if they want to do the COIN FLIP CHALLENGE. If they want to, they will have ten rounds to guess if the program got heads or tails. Every correct guess will add 1 to their total. Once completed, display the total correct back to the user. 

## Requirements

The user’s name should be stored in a variable so you can reference it later.
The challenge should only run if the user agrees to it.
If the user doesn’t agree, call them a coward and end the program without doing the challenge.
The challenge should have five rounds.
During each round the program secretly picks a random number: 0 or 1
Ask the user for heads or tails. Compare it to the random number.
These won’t nicely compare. You will have to come up with how heads and tails relate to 0 and 1.
Each right answer adds one to the total.
First, ask the user, “What is your name?” Store their response in a variable called name. Then ask the user if they want to do the COIN FLIP CHALLENGE. If they type “No”, call them a coward and end the program. If they choose yes, the challenge begins.

The challenge: Create a variable that holds the score. Start it to 0. Create a loop that runs five times. During each loop, get a random number and store that value. That should be a 0 or a 1. Ask the user to enter heads or tails and then store their response. You will then have to compare the random number to the user input. These values will not compare together normally. You will have to get creative to compare them. If the user has successfully guessed the answer, add one to their score and tell the user. Once the loop has finished, the challenge is over. Tell the user their score.


## Example Output

Example 1:
Welcome to the COIN FLIP CHALLENGE!
What is your name?
>Grant Chirpus
Welcome Grant Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No
>No
You are a coward Grant Chirpus

Example 2:
Welcome to the COIN FLIP CHALLENGE!
What is your name?
>Grant Chirpus
Welcome Grant Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No
>Yes
Heads or Tails?
>Heads
Correct!
Heads or Tails?
>Heads
Wrong!
(This repeats 3 more times. Pretend they got it right 2 more times)
Thank you Grant Chirpus. You got a score of 3!



## Grading Criteria

Grading Criteria: 10 points total
Ask the user for their name and store it.
The name is used throughout the program
The user is called a coward if they do not agree to the COIN FLIP CHALLENGE
Only do the COIN FLIP CHALLENGE if the user agrees.
Loop the challenge 5 times
The program grabs a random number between 0 and 1 (You still get this point even if nothing is done with it.)
The user is asked for heads or tails and their value is stored.
A solution was found to compare the random number to the heads or tails input that works.
Every correct answer adds one to the score.
The score is displayed at the end of the challenge

