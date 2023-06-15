#include <bits/stdc++.h> 
int maximumProfit(vector<int> &prices){
    int min = prices[0], maxPro = 0;
    for(int i=1; i<prices.size(); i++)
    {
        min = min > prices[i] ? prices[i] : min;
        maxPro = maxPro > (prices[i] - min) ? maxPro : (prices[i] - min);
    }
    return maxPro;
}
