#include <bits/stdc++.h>

int findMajorityElement(int arr[], int n) {
    int ele = 0, cnt = 0;

    for(int i=0;i<n;i++)
    {
        if(cnt == 0 || ele == arr[i]){
            ele = arr[i];
            cnt++;
        }else{
            cnt--;
        }
    }
    int fcnt =0;
    if(cnt>0)
    {
        for(int i=0;i<n;i++)
            if(ele == arr[i])
                fcnt++;
    }

    if(fcnt > n/2)
        return ele;
    else
        return -1;
}
