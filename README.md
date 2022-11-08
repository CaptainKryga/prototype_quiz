# prototype Quiz or "Field of Dreams"

Implemented on Unity 2021.3

![image](https://user-images.githubusercontent.com/43387685/200600120-05b73b29-f229-4e2d-83cd-0eb3d71103dd.png)

## There is a basic interface:
* Main menu.
* Game menu.

## Level types:
* Pre-prepared depending on the GameSettings(ScriptableObject) settings.

![image](https://user-images.githubusercontent.com/43387685/200600443-3ac24dcc-ad89-441e-ae3e-beae60f6e6f5.png)
![image](https://user-images.githubusercontent.com/43387685/200600714-e93216ec-5070-4e08-8fc5-5cd3716fa685.png)

## Mechanics:
* The application reads all the words from the file, and then, depending on the settings, these words are used in the game.
* For guessing, the player has a set of letters on the buttons, a word closed behind the squares, the number of attempts and points.
* When a player clicks on a letter, it disappears and, if found in a word, the corresponding squares open.
* If it does not occur, then the number of attempts decreases.
* If the number of attempts becomes negative, then the player loses, a message is shown and the game starts again with zero points.
* If the word is completely guessed, then the player's score is increased by the number of remaining attempts and the game starts again.
* The available letters and the number of attempts are also reset.
* Words that have been used must not be repeated until the player has lost.
* If there are no more suitable words, then the player is informed that he has completed the game and the game starts again with a complete reset of points and used words.
* A separate setting specifies what the minimum word length should be, words of lesser length should be ignored.
* The case is also ignored, the words "the" and "The" are considered the same.

## Links:
--
