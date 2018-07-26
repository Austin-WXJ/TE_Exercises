/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
    var prezdiv = $("#presidents div").addClass("president");
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    var findGeorge = $("#george-washington").addClass("founding-father");
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    var findRepubs = $(".Republican").addClass("red");
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    var findDems = $(".Democratic").addClass("blue");
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    var others = $(".president:not(.Republican):not(.Democratic)").addClass('gold');
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    var findJames = $('div[id^="james"]').addClass("james");
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    var BoCPrez = $("#presidents h2").next().addClass('beginningOfCentury');
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    //var  oldDeadGuys = $("#presidents h2").prev().addClass('beginningOfCentury')
    //var currentPrez = $('#presidents div:last');
    var allEoCPrez = $("#presidents h2").prev().addClass('beginningOfCentury').add($('#presidents div:last')).addClass('endOfCentury');

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    var currencyPres1900 = $('main div h2:nth-of-type(3) ~ .currency').addClass('appearOnCurrency');


}