
(function () {
    $("#btnAdd").on("click", function () {
        let ret = false;
        if (!isEmpty("#addCompanyName", "#addPhone")) {
            ret = true;
            if (isCorrectPhone('#addPhone')) {
                ret = true;
            } else {
                $('#messageAdd').html("El numero no es valido");
                ret = false;
            }
        } else {
            $('#messageAdd').html("Complete los campos para continuar con la carga");
        }
        
        if (ret) {
            $.ajax({
                type: 'POST',
                url: "/Shipper/AddOrUpdate",
                dataType: "json",
                content: "application/json; charset=utf-8",
                data: {
                    CompanyName: $("#addCompanyName").val(),
                    Phone: $("#addPhone").val()
                },
                statusCode: {
                    200: function () {
                        alert("Added!!!");
                    },
                    404: function () {
                        alert("Error!!!");
                    }
                }
            });
        } 
    });

    $('[data-action="modificar"]').on("click", function () {
        let value = $(this).attr("data-obj");
        console.log(value);
        $("#id").html(value);

        $("#saveChanges").on("click", function () {
            let ret = false;
            if (!isEmpty("#btnUpdateCompanyName", "#btnUpdatePhone")) {
                ret = true;
                if (isCorrectPhone('#btnUpdatePhone')) {
                    ret = true;
                } else {
                    alert("el numero no es correcto")
                    ret = false;
                }
            } else {
                alert("Los campos estan vacios");
            }
            if (ret) {
                $.ajax({
                    type: 'POST',
                    url: "/Shipper/AddOrUpdate",
                    dataType: "json",
                    content: "application/json; charset=utf-8",
                    data: {
                        ShipperID: parseInt(value, 10),
                        CompanyName: $("#btnUpdateCompanyName").val(),
                        Phone: $("#btnUpdatePhone").val()
                    },
                    statusCode: {
                        200: function () {
                            alert("Updated!!");
                        },
                        404: function () {
                            alert("Error!!!");
                        }
                    }
                });
            }
        });
    });

    $('[data-action="eliminar"]').on("click", function () {
        let value = $(this).attr("data-obj-delete");
        var opcion = confirm(`Are you sure you want to delete? ${value}`);
        if (opcion == true) {
            $.ajax({
                type: 'POST',
                url: "/Shipper/Delete",
                dataType: "json",
                data: {
                    ShipperID: parseInt(value, 10)
                },
                statusCode: {
                    200: function (resultado) {
                        if (resultado == 200) {
                            alert("Deleted!!!");
                        } else {
                            alert("Ocurrio un error al eliminar!");
                        } 
                    },
                    404: function () {
                        alert("Error!!!");
                    }
                }
            });
            
        }
    });
})();



function isEmpty(name,phone) {
    if ($(name).val() == "" ||
        $(phone).val() == "") {
        return true;
    }
    return false;
}

function isCorrectPhone(selector) {
    let phone = $(selector).val();
    const regex = /^[0-9]*$/;
    let trim = phone.replace(/ /g, "");
    
    if (regex.test(trim)) {
        return true;
    }
    return false;
}

