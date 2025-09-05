Idea of a knapsack 
up to this point what is the best deal I can get 

taking this item so far and all the weights for that Items 


if the current item is too heavy 
you dont take it and the best weight you can have is given excluding that item the item above i.e the row above 
dp[i-1][w] go to the previos Item of the same weight 


if the w is less than the current capacity 
2 options , Include it or exclude it 
we take the best of each 

dp[i-1][w] skip 
or take value[ith item]  + (the MAX value I get with the remaining item with the remaining weight)  you will get it by the current row 
dp[i-1][w] = max(dp[i-1][w] , value[i] + dp[i-1][w - weight[i]])
