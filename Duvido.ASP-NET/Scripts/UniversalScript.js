window.onload = function () {

    var myMusic = document.getElementById("music");
    var muteButton = $("#mute");



    muteButton.click(function () {
        if (myMusic.paused) {
            myMusic.play();
            muteButton.removeClass("muted");
        } else {
            myMusic.pause();
            muteButton.addClass("muted");
        }
    });

}