

$('#btn1').click(function () {
    swal("Sitemizde verdiğiniz mail adresi üzerinden bilgi ve haber e-postaları spam ölçüsüne varmadan gönderilmeye devam edilecektir. Eğer e-posta bülteninden çıkmak isterseniz mail ileti dizisini durdurabilirsiniz, şifre ve mail adresleriniz şifrelenmiş formatta herhangi bir kullanıcının göremeyeceği şekilde veritabanımızda saklanmaktadır.");
});

$(document).ready(function () {
    var $submitBtn = $("#form button[type='submit']");
    var $passwordBox = $("#password1");
    var $confirmBox = $("#password2");
    var $errorMsg = $('<span id="error_msg">Şifreler aynı değil.</span>');

    // This is incase the user hits refresh - some browsers will maintain the disabled state of the button.
    $submitBtn.removeAttr("disabled");

    function checkMatchingPasswords() {
        if ($confirmBox.val() != "" && $passwordBox.val != "") {
            if ($confirmBox.val() != $passwordBox.val()) {
                $submitBtn.attr("disabled", "disabled");
                $errorMsg.insertAfter($confirmBox);
            }
        }
    }

    function resetPasswordError() {
        $submitBtn.removeAttr("disabled");
        var $errorCont = $("#error_msg");
        if ($errorCont.length > 0) {
            $errorCont.remove();
        }
    }


    $("#password2, #password1")
        .on("keydown", function (e) {
            /* only check when the tab or enter keys are pressed
* to prevent the method from being called needlessly  */
            if (e.keyCode == 13 || e.keyCode == 9) {
                checkMatchingPasswords();
            }
        })
        .on("blur", function () {
            // also check when the element looses focus (clicks somewhere else)
            checkMatchingPasswords();
        })
        .on("focus", function () {
            // reset the error message when they go to make a change
            resetPasswordError();
        })
    $('#submitBtn').click(function () {
        checkMatchingPasswords();
    });

});
