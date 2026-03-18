package DATASTRUCT;

public class lastName_gradeBook {

	public static void main(String[] a) {

		int[][] grade = { { 87, 96, 70 }, { 68, 87, 90 }, { 94, 100, 90 }, { 100, 81, 82 }, { 83, 65, 85 },
				{ 78, 87, 65 }, { 85, 75, 63 }, { 91, 94, 100 }, { 76, 72, 84 }, { 87, 93, 73 } };
		int Hightemp = grade[0][0];
		int Lowtemp = grade[0][0];

		System.out.println("Welcome to the grade book for" + "\n" + "CS101 Introduction to C++ Programming!" + "\n"
				+ "The grades are:" + "\n");
		System.out.printf("%-12s %-8s %-8s %-8s %8s", " ", "Test 1", "Test 2", "Test 3", "Average");
		System.out.println();
		for (int i = 0; i < grade.length; i++) {
			float average = 0;
			System.out.printf("%-8s %-2d %-2s %-1s", "Student", (i + 1), ": ", " ");
			for (int j = 0; j < grade[i].length; j++) {

				average += grade[i][j];
				System.out.printf("%-9s", grade[i][j]);

			}
			System.out.printf("%3.2f", average / 3.0);
			System.out.println();

		}

		for (int i = 0; i < grade.length; i++) {
			// ... your printing code ...
			for (int j = 0; j < grade[i].length; j++) {

				// Update High
				if (grade[i][j] > Hightemp) {
					Hightemp = grade[i][j];
				}

				// Update Low (Independent check)
				if (grade[i][j] < Lowtemp) {
					Lowtemp = grade[i][j];
				}
			}
		}
		
		System.out.println("\nThe lowest grade in the grade book is " + Lowtemp);
		System.out.println("The highest grade in the grade book is " + Hightemp);
	}
}