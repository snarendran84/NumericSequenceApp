// Write your Javascript code.
$(document).ready(function () {
    $("#numericForm").validate({
        rules: {
            numberInput: "required"
        },
        messages: {
            numberInput: "Please specify a non-zero whole number"
        }
    })
});


$('#btnNumSeq').click(function () {
    $("#numericForm").valid();
    $.get('api/NumericSequenceApi/GetNumericSequence/' + $('#numberInput').val(), function (data) {
        //... do something with response from server
        $("#lblModalTitle").text('Number Sequence');
        $("#lblModalBody").text(data);
        $("#seqModal").modal('show');
    });
});

// Write your Javascript code.
$('#btnOddNumSeq').click(function () {
    if ($("input[id=numberInput]").valid()) {
        $.get('api/NumericSequenceApi/GetOddNumberSequence/' + $('#numberInput').val(), function (data) {
            //... do something with response from server
            $("#lblModalTitle").text('Odd Number Sequence');
            $("#lblModalBody").text(data);
            $("#seqModal").modal('show');
        });
    }
    else {
        ShowValidationMessage();
    }
});

ShowValidationMessage = function () {

    $("#lblModalTitle").text('Validation Error');
    $("#lblModalBody").text('Please enter a valid non-zero whole number');
    $("#seqModal").modal('show');
}

// Write your Javascript code.
$('#btnEvenNumSeq').click(function () {
    $("#numericForm").valid();
    $.get('api/NumericSequenceApi/GetEvenNumberSequence/' + $('#numberInput').val(), function (data) {
        //... do something with response from server
        $("#lblModalTitle").text('Even Number Sequence');
        $("#lblModalBody").text(data);
        $("#seqModal").modal('show');
    });
});

// Write your Javascript code.
$('#btnFibNumSeq').click(function () {
    $("#numericForm").valid();
    $.get('api/NumericSequenceApi/GetFibonacciSequence/' + $('#numberInput').val(), function (data) {
        //... do something with response from server
        $("#lblModalTitle").text('Fibonacci Sequence');
        $("#lblModalBody").text(data);
        $("#seqModal").modal('show');
    });
});

