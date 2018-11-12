

function activityClick() {
    var modal = document.getElementsByClassName("act1");
    $(modal).click(function (e) {
        e.preventDefault();
        var id = $(this)[0].id;

        $.ajax({
            url: "ModalService",
            contentType: 'application/json',
            data: { 'idService': id, 'typeService': 'activity' },
            traditional: true,
            dataType: "json",
            type: "get",
            success: function (response) {

                $("#modalNom").text(response.Nom);
                $("#modalNom").css({ "min-width": "400px" });
                $(".star").css({ "display": "none" });
                $("#modalNomService").text("Activité : ");

                $("#modalTypeServiceNom").text("Activités :");
                $("#modalTypeService").html("");
                var listActivities = response.ActiviteTypes.split(',');
                for (var i = 0; i < listActivities.length; i++) {
                    $("#modalTypeService").html("<p class= 'user-name col-lg-6 col-md-6 col-12' >\<span class='lnr lnr-checkmark-circle'></span>\<a href='#' style='color: #697179 '> " + listActivities[i] + "</a >\</p > " + $("#modalTypeService").html());
                }

                $("#modalAdresse").text(response.Adresse);
                if (response.Tel == " " || response.Tel == null)
                    $("#modalTel").text("Non disponible");
                else
                    $("#modalTel").text(response.Tel);
                $("#modalImg").attr({ "src": response.Img });
                $("#modalClassement").text("Top " + response.ClassementIntype + " sur Tripadvisor");

                $("#modalDescName").text(response.Nom);
                $("#modalDescContent").text("Dans un décor d’exception, tout en marbre rose , de tadelakt, de pierre naturelle, de tataoui.Laissez-vous tenter par notre Spa, dont la gamme de massages, soins du corps et du visage, ainsi que notre hammam traditionnel, vous seront proposés par une équipe de professionnelles dévouées à votre détente.A très vite dans votre centre Noura Spa.");
                $("#modalLien").attr({ "href": response.PlusInfo });
                $("#modalLien").text("Plus d'info");
            }
        });
        $("#myModal").modal();

        $("#modalConseil").css({ "display": "none" });
    });
}
activityClick();


function hotelClick() {
    var modal = document.getElementsByClassName("act1");
    $(modal).click(function (e) {
        e.preventDefault();
        var id = $(this)[0].id;
        $("#hotelInfos").css({ "display": "block" });
        $.ajax({
            url: "ModalService",
            contentType: 'application/json',
            data: { 'idService': id, 'typeService': 'hotel' },
            traditional: true,
            dataType: "json",
            type: "get",
            success: function (response) {

                $("#modalNom").text(response.Hotel);
                $("#modalNom").css({ "min-width": "400px" });

                $("#modalNomService").text("Hotel : ");

                $("#modalTypeServiceNom").text("Services :");
                $("#modalTypeService").html("");
                var listActivities = response.DescMeilleursServices.split(',');
                for (var i = 0; i < listActivities.length; i++) {
                    $("#modalTypeService").html("<p class= 'user-name col-lg-6 col-md-6 col-12' >\<span class='lnr lnr-checkmark-circle'></span>\<a href='#' style='color: #697179 '> " + listActivities[i] + "</a >\</p > " + $("#modalTypeService").html());
                }

                $("#modalAdresse").text(response.Adresse);
                if (response.Tel == " " || response.Tel == null)
                    $("#modalTel").text("Non disponible");
                else
                    $("#modalTel").text(response.Tel);
                $("#modalImg").attr({ "src": response.Img });
                $("#modalClassement").text("Top " + response.Classement + " sur Tripadvisor");

                $("#modalDescName").text(response.Hotel);
                $("#modalDescContent").text("a une disposition traditionnelle - le bâtiment entoure un espace extérieur charmant qui a sa propre piscine. Les clients peuvent prendre un bain quand ils veulent échapper à la chaleur de Marrakech. C'est l'une des expériences luxueuses ultimes pendant que vous restez dans la ville; C'est merveilleux de retourner au Riad après une journée d'exploration et de détente dans la piscine.");
                $("#modalLien").attr({ "href": response.LienRes });
                $("#modalLien").text("Réserver");

                $("#modalPrix").text(response.Prix +" MAD");
                var etoiles = response.DescNbrEtoils;

                $("#modalStar").attr({ "src": "images/etoiles/" + etoiles + ".png" });
                

            }
        });
        $("#myModal").modal();
        $("#modalConseil").css({ "display": "none" });
    });
}
hotelClick();

var abc;
function restcafeClick() {
    var modal = document.getElementsByClassName("act1");
    $(modal).click(function (e) {
        e.preventDefault();
        var id = $(this)[0].id;

        $.ajax({
            url: "ModalService",
            contentType: 'application/json',
            data: { 'idService': id, 'typeService': 'restaurant' },
            traditional: true,
            dataType: "json",
            type: "get",
            success: function (response) {

                $("#modalNom").text(response.ResEtab);
                $("#modalNom").css({ "min-width": "400px" });
                $(".star").css({ "display": "none" });
                $("#modalNomService").text("Restaurant : ");

                $("#modalTypeServiceNom").text("Cuisines :");
                $("#modalTypeService").html("");
                var listActivities = response.Repas.split(',');
                for (var i = 0; i < listActivities.length; i++) {
                    $("#modalTypeService").html("<p class= 'user-name col-lg-6 col-md-6 col-12' >\<span class='lnr lnr-checkmark-circle'></span>\<a href='#' style='color: #697179 '> " + listActivities[i] + "</a >\</p > " + $("#modalTypeService").html());
                }

                $("#modalAdresse").text(response.Adresse);
                if (response.Tel == " " || response.Tel == null || response.Tel=="")
                    $("#modalTel").text("Non disponible");
                else
                    $("#modalTel").text(response.Tel);
                $("#modalImg").attr({ "src": response.Img });
                /* pas encore */
                $("#modalClassement").text("Top " + Math.floor((Math.random() * 300) + 1) + " sur Tripadvisor");

                $("#modalDescName").text(response.ResEtab);
                $("#modalDescContent").text("Dans un décor d’exception, tout en marbre rose , de tadelakt, de pierre naturelle, de tataoui.Laissez-vous tenter par notre Spa, dont la gamme de massages, soins du corps et du visage, ainsi que notre hammam traditionnel, vous seront proposés par une équipe de professionnelles dévouées à votre détente.A très vite dans votre centre Noura Spa.");
                $("#modalLien").attr({ "href": response.InfoPlus });
                $("#modalLien").text("Plus d'info");

                $("#modalConseil").css({ "display": "block" });
                
            }
        });
        $("#myModal").modal();

    });
}
restcafeClick();