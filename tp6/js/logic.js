"use strict";
$(function(){
      $("#name").on("keyup", function(){
            let name = $('#name').val();
            isEmpty(name,'#name');

      });
      $("#surname").on("keyup", function(){
            let surname = $('#surname').val();
            isEmpty(surname,'#surname');
      });
      $("#mail").on("keyup", function(){
            let mail = $('#mail').val();
            isEmpty(mail,'#mail');

      });
      $("#age").on("keyup", function(){
            let age = $('#age').val();
            isEmpty(age,'#age');

      });
      
      
});

function isEmpty(value,selector){
      if (value != "") {
            $(selector).css("border","1px solid grey");

      }else{
            $(selector).css("border","1px solid red"); 
            $(selector).attr("placeholder","This field cannot be empty");
      }         
}

function Clear(){
      $('#name').val("");
      $('#surname').val("");
      $('#mail').val("");
      $('#age').val("");
      $('#job').val("");
      $('#bio').val("");
      $('#development').attr('checked',false);
      $('#design').attr('checked',false);
      $('#bussines').attr('checked',false);

      $('#name').css("border","1px solid red"); 
      $('#surname').css("border","1px solid red"); 
      $('#mail').css("border","1px solid red"); 
      $('#age').css("border","1px solid red"); 
}

function Submit(){
      let ret = true;
      let arrayElements = [
            $('#name').val(),
            $('#surname').val(),
            $('#mail').val(),
            $('#age').val()
      ];
      arrayElements.forEach(element => {
            if (element == "") {
                  $('#errorMessage').html("invalid fields");
                  ret = false;
            }
      });
      ret == true ? $('#errorMessage').html("") : null;
      
      
}