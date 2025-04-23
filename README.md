# Boom Boom Roulette

## Overview
A roulette style Windows Forms app developed in C#. This app simulates the mechanics of a game of russian roulette but instead it uses a nerf gun. The app does this by "loading" a nerf gun with either "live" or "blank" darts. The user can point the nerf gun at either themselves or their opponent, that being the computer. The user then fires the dart and either there will be a "Bang" meaning it was a "live" dart, or there will be a "Click" meaning that it was a "Blank" dart. Each time there is a bank, the person whom the nerf gun is pointed at loses health. When either the player or the computer reach 0 health, a Victory condition is called, and whomever has health remaining is declared the winner.

## User Experience
When the user starts the application, they are first presented with a Main Menu that allows them to enter there name, and button that says "Start Simulation P1". Upon hitting that button, they are taken to a screen that shows the UI needed for the simulation. This consists of an events log, the health counters for both the player and the computer, and a text label that shows who the Nerf gun is pointed at. 

### Running the Simulation
In order to start the simulation, the user must input how much health the player's will have. The players being the user, and the computer. Users must imput an integer. 

## Features
- Function that generates and array of data that contains whether a round is considered "Live or Not". It this by using a for loop that generates a random number. Then based on the random adds a string to the array. This string can either be "Live" or "Blank".
- The ability to save user data to a file then refrence it later.

## YouTube Video Link
https://youtu.be/pcdj-lBgnJM
