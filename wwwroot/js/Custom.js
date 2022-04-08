
$(function () {
    $("body").on('mousemove', function () {
        ResetThisSession();
    });

});
var timeInSecondsAfterSessionOut = 300;
var secondTick = 0;
function ResetThisSession() {
    secondTick = 0;
}
function StartThisSessionTimer() {
    secondTick++;
    var timeLeft = ((timeInSecondsAfterSessionOut - secondTick) / 60).toFixed(0);
    timeLeft = timeInSecondsAfterSessionOut - secondTick;
    if (timeLeft == 60) {
        $('#Warning_TimeLeft').modal('show');
    }
    $("#spanTimeLeft").html(timeLeft);

    if (secondTick > timeInSecondsAfterSessionOut) {
        clearTimeout(tick);
        window.location = "/Account/SignOut";
        return;
    }
    tick = setTimeout("StartThisSessionTimer()", 1000);
}
StartThisSessionTimer();

