import java.util.Scanner;

import javax.swing.text.Style;
import javax.swing.text.html.parser.Element;

public class Main {
    public static void main(String[] args) {

        System.out.println("Enter umaga or hapon...");

        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        String output;
        if (input.contains("hapon")) output = "umaga";
        else output = "hapon";

        System.out.println("Magandang "+ output + " baby!");
        
    }
}