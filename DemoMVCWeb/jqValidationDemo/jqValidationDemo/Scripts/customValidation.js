$(document).ready(function () {
    //Add rules for title field
    $("#Title").rules("add", {
        required: true,
        messages: {
            required: "Please enter a title",
        }
    });
    //Add rules for ListItemEntry field
    $("#ListItemEntry").rules("add", {
        required: true,
        messages: {
            required: "Please enter some activities",
        }
    });
});