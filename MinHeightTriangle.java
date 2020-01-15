import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int lowestTriangle(int base, int area){
        // Complete this function
        return (int) Math.ceil((2 * area) / (double) base); 
    }