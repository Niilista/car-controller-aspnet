var table = document.getElementById("table1");
window.onload = callCreatePerson;
function callCreatePerson() {
    $.ajax({
        url: 'GetDocumentos',
        data: {},
        method: 'POST',
        dataType: "json"
    }).then(function (data) {
        console.log(data);
        feedTable(data);
    });
}


sortTable();

function sortTable() {
    const getCellValue = (tr, idx) => tr.children[idx].innerText || tr.children[idx].textContent;

    const comparer = (idx, asc) => (a, b) => ((v1, v2) =>
        v1 !== '' && v2 !== '' && !isNaN(v1) && !isNaN(v2) ? v1 - v2 : v1.toString().localeCompare(v2)
    )(getCellValue(asc ? a : b, idx), getCellValue(asc ? b : a, idx));

    // do the work...
    document.querySelectorAll('th').forEach(th => th.addEventListener('click', (() => {
        const table = th.closest('table');
        Array.from(table.querySelectorAll('tr:nth-child(n+2)'))
            .sort(comparer(Array.from(th.parentNode.children).indexOf(th), this.asc = !this.asc))
            .forEach(tr => table.appendChild(tr));
    })));
}

function feedTable(data) {
    clearTable();
    let i = 1;
    data.forEach(function (item) {
        let newRow = table.insertRow(i);
        feedRow(newRow, item);
        i++;
    });
    h1.innerHTML = countRows() - 1 + " resultados encontrados";
}

function feedRow(row, item) {
    for (let key in item) {
        let value = item[key];
        feedCell(row.insertCell(), value);
    }
}

function feedCell(cell, name) {
    if (name.includes("T00:00:00")) {
        name = name.split("T")[0];
    }
    cell.innerText = name;
    cell.className = "centralize";

}

function clearTable() {
    var rows = document.getElementsByTagName("tr");
    for (var i = 1; i < rows.length; i++) {
        table.deleteRow(i);
        i--;
    }
}