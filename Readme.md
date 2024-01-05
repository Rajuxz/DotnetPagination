# Dotnet Pagination.

Do you think that this repository contains another model named Pager, and are you concerned that it might be too complex? Don't worry; it is not, and it works smoothly.  All you need to do is copy and paste the code i provided following these steps.

- Copy the `Pager.cs` file and place inside Models folder. 
- Create a partial view named `_Paginator.cshtml` (as i did) just like i do and paste the code it contains. This maintains code readability and prevents code repetation.
- Configure the Paginator in your razor view where you want to place it. `(Refer ViewStudent.cshtml file inside Views/Student)`

- Just call the partial view wherever you want as follows.
    `<partial name="~/Views/Shared/_Paginator.cshtml" model="@pager"/> `

<b>Wasn't it easy? 😁</b> 
<hr>
<i>Feel Free to Ctrl+C and Ctrl+V. Happy Coding 🤞 !!! </i>
