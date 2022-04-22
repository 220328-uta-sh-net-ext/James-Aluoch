#!/bin/bash


#program for Fibonacci Series
# Static input fo N 
n=8  
# First no 
a=0  
# Second no
b=1     
echo "The Fibonacci series is : " 
for (( i=0; i<n; i++ )) 
do
    echo -n "$a "
    temp=$((a + b)) 
    a=$b 
    b=$temp 
done
