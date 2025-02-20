package lesson1.mora.prag;

import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);


    public static void main(String[] args) {
        //פקודת פלט
        System.out.println("hello");

        //פקודת קלט
        int x = scanner.nextInt();
        System.out.println(x * 2);
    }
}
