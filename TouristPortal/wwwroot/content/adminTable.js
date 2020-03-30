function show() {
    if (document.getElementById("productsTable").style.display !== 'none') {
        document.getElementById("productsTable").style.display = 'none';
        document.getElementById("ordersTable").style.display = 'block';
    }
    else {
        document.getElementById("productsTable").style.display = 'block';
        document.getElementById("ordersTable").style.display = 'none';
    }
}
$(document).ready(function () {
    $('#tbproducts tfoot th').each(function () {
        $(this).html('<input class="tableinput" type="text" placeholder="Wyszukaj..." />');
    });
    var table = $('#tbproducts').DataTable({
        "dom": '<"chosen form-border" fl>rt<"col-sm-12"p><"clear">',
        orderCellsTop: true,
        fixedColumns: true,
        scrollX: false,
        lengthMenu: [10, 25, 50],
        language: {
            lengthMenu: "_MENU_",
            zeroRecords: "Nie znaleziono żadnych elementów",
            info: "Strona _PAGE_ z _PAGES_",
            infoEmpty: "Brak danych",
            infoFiltered: "(wybrano spośród _MAX_ wszystkich rekordów)",
            search: "",
            sSearchPlaceholder: "Wyszukaj...",
            paginate: {
                "first": "Pierwszy",
                "last": "Ostatni",
                "next": " »",
                "previous": "« "
            },
        },
    })
    table.columns().every(function () {
        var that = this;

        $('input', this.footer()).on('keyup change clear', function () {
            if (that.search() !== this.value) {
                that
                    .search(this.value)
                    .draw();
            }
        });
    });
    $('#tborders tfoot th').each(function () {
        $(this).html('<input class="tableinput" type="text" placeholder="Wyszukaj..." />');
    });
    var table = $('#tborders').DataTable({
        "dom": '<"chosen form-border" fl>rt<"col-sm-12"p><"clear">',
        orderCellsTop: true,
        fixedColumns: true,
        scrollX: false,
        lengthMenu: [10, 25, 50],
        language: {
            lengthMenu: "_MENU_",
            zeroRecords: "Nie znaleziono żadnych elementów",
            info: "Strona _PAGE_ z _PAGES_",
            infoEmpty: "Brak danych",
            infoFiltered: "(wybrano spośród _MAX_ wszystkich rekordów)",
            search: "",
            sSearchPlaceholder: "Wyszukaj...",
            paginate: {
                "first": "Pierwszy",
                "last": "Ostatni",
                "next": " »",
                "previous": "« "
            },
        },
    })
    table.columns().every(function () {
        var that = this;

        $('input', this.footer()).on('keyup change clear', function () {
            if (that.search() !== this.value) {
                that
                    .search(this.value)
                    .draw();
            }
        });
    });
});