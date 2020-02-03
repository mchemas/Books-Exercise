Coding Exercise

Create a small webpage in C# with the following features. (You can use mvc or
  just asp.net webpage)

  1. webpage should allow the user to fill Bookname, authorname, price and a
    publisher (5 predefined list of publisher names that the user can choose from)
  2. After filling the info, it should save the data to a database table or a
    file along with saved date time .
  3. After saving, the data should be displayed in a datagrid on the same page
    that should allow the user to update if needed or delete that record
  4. Page should notify user if the book name is already in the database. Try to
    use Linq query.
  5. Add proper validation and error handling to the page

This was a coding challenge I was given which I had 3 days to complete. Prior to
this, I had no experience using C#. The purpose of the exercise was to see how
much I could self learn in a short amount of time. Given those constraints, I was
able to successfully implement a majority of the features.

1 - Insert new book worked completely, including having a predefined list of
  publishers.
2 - Data was saved to a local MySQL database, saved date time was not implemented
  due to time constraints.
3 - Datagrid display worked completely, including update & delete functionality.
4 - Duplicate title worked using custom NoDuplicate function.
5 - Input validation & error handling all worked.
