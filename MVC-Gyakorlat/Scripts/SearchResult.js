$(document).ready(function () {
    $("Details").hide();
    $(".DetailsLink").click(downloadDetails);
})

function downloadDetails(event) {
    event.preventDefault();
    $("#Details").hide("slow");
    $.get($(this).attr("href"),downloadDetailsFinished);

}


function downloadDetailsFinished(htmlResult) {
    $("#DetailsData").html(htmlResult);
    $("#Details").show("slow");

}