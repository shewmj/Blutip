1. 
I thought about using str.Replace(char, char) to convert the characters to their corresponding numbers but I think it would be less efficient since it likely compares every character of the string each call. Instead I decided to iterate over each character and convert them to lowercase to reduce the amount of switch cases that i needed to use. This way I only iterate over each character once and can use half the comparisons by first casting to lowercase and then comparing. 

2. 
I first tested for a empty string since I need access to the first character before I start counting duplicates but this would create a error if the first character does not exist. Then I keep iterating through the string and keep count of the same characters in a row until a new charcter is seen at which point i reset the counter and add the collected data onto a new string which will be returned at the end. At the end I empty the "buffer" of data onto the returning string and then finish. 