let upperForm  = code;
let bottomForm = $('.bottomForm');
let runButton = $('.runButton');

let sendData = c_sendData();

upperForm.on("change", event => sendData(event));

runButton.on("click", () => {
    runButton.prop("disabled", true);

    $.post({
        url: "http://127.0.0.1:8080/",
        data: {
          code: upperForm.getValue()
        },

        success: resp => {
            runButton.prop("disabled", false);
            bottomForm.val(resp.output + "\n\n" + resp.traceback);
        },

        crossDomain: true,
    }).fail(err => {
        alert(err.statusText);
    });
});

sendData({ type: 'hashCheck' });