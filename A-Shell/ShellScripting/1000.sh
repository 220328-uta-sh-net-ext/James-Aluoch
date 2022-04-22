#!/bin/bash
echo "please enter a number"
read a
if  [ $a -lt 100 ]; then
echo "It is less than 100";
elif [ $a -lt 1000 ]; then
echo "It is less than 1000"
else
echo "It is greater than 1000"
fi
exit 0