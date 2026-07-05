const uri = "http://localhost:5298";
let _section = "businessTransactions";
let _lastSection = "";
let _transactions;
let _autos;
let _maxPage = 1;
let _currentPage = 1;
let _categories;
let _suppliers;
let _currentUrl = "";
let _order = "id";
let _businessTransactionSearch = {
    name: '',
    dateBox: false,
    dateMode: 'more',
    date: new Date(Date.now()).toISOString().slice(0, 10),
    amountBox: false,
    amountMode: 'more',
    amount: 0,
    categoryId: 0,
    supplierId: 0,
    recurrent: 0,
};

//#region fetch methods

async function getBusinessItems(section) {
    if (section === "businessCategories" || section === "businessTransactions" || section === 'businessSuppliers') _section = section;
    sessionStorage.setItem('section', _section);

    if (_section === 'businessCategories') {
        await fetch(`${uri}/BusinessCategory`)
            .then(res => res.json())
            .then(data => _categories = data)
            .catch(error => console.error('Unbalie to fetch categories', error));
    }

    if (_section === 'businessSuppliers') {
        await fetch(`${uri}/BusinessSupplier`)
            .then(res => res.json())
            .then(data => _suppliers = data)
            .catch(error => console.error('Unable to fetch suppliers', error));
    }

    if (_section === 'businessTransactions') {
        _currentUrl = _setUrl();
        if (_currentUrl != sessionStorage.getItem('lastUrl')) {
            await fetch(`${uri}/BusinessCategory`)
                .then(res => res.json())
                .then(data => _categories = data)
                .catch(error => console.error('Unbalie to fetch categories', error));

            await fetch(`${uri}/BusinessSupplier`)
                .then(res => res.json())
                .then(data => _suppliers = data)
                .catch(error => console.error('Unable to fetch suppliers', error));

            await fetch(_currentUrl).
                then(res => res.json())
                .then(data => {
                    _transactions = data;
                    sessionStorage.setItem('lastUrl', _currentUrl);
                    _transactions.forEach(x => { x.category = _categories.find(y => y.id === x.categoryId); x.supplier = _suppliers.find(y => y.id === x.supplierId); });
                    _getTransactionMaxPage();
                })
                .catch(error => console.error(`Unbale to get ${_section}.`, error));
        }
        _setPagination();
    }
    _displayBusinessItems();
    if (_lastSection != _section) setSearch();
    _lastSection = _section;
}

async function addBusinessTransaction() {
    let transaction = {
        name: document.getElementById('transaction-add-name').value,
        date: document.getElementById('transaction-add-date').value.substring(0, 10),
        amount: document.getElementById('transaction-add-amount').value,
        categoryId: document.getElementById('transaction-add-category').value,
        supplierId: document.getElementById('transaction-add-supplier').value,
    };

    sessionStorage.setItem('lastUrl', "");

    await fetch(`${uri}/BusinessTransaction/Create`, {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(transaction)
    })
        .then(() => {
            closeModalDiv();
            getBusinessItems();
        })
        .catch(error => console.error('Unbale to post transaction', error));
}

async function editBusinessTransaction(id) {
    let transaction = _transactions.find(x => x.id === id);

    if (transaction != null) {
        transaction = {
            id: id,
            name: document.getElementById('transaction-edit-name').value,
            date: document.getElementById('transaction-edit-date').value,
            categoryId: document.getElementById('transaction-edit-category').value,
            amount: document.getElementById('transaction-edit-amount').value,
            supplierId: document.getElementById('transaction-edit-supplier').value,
        };

        sessionStorage.setItem('lastUrl', "");

        await fetch(`${uri}/BusinessTransaction/Edit/${id}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(transaction)
        })
            .then(() => {
                closeModalDiv();
                getBusinessItems(_section);
            })
            .catch(error => console.error(`Unable to update transaction:\n ${JSON.stringify(transaction)}`, error));
    }
    else alert('The transaction cannot be found');
}

async function deleteBusinessTransaction(id) {
    let transaction = _transactions.find(x => x.id === id);

    if (transaction != null) {
        if (confirm(`Are you sure you want to delete this transaction?`))
            sessionStorage.setItem('lastUrl', "");

        await fetch(`${uri}/BusinessTransaction/Delete/${id}`, { method: 'DELETE' })
            .then(() => {
                closeModalDiv();
                getBusinessItems(_section);
            })
            .catch(error => console.error('Unable to delete transaction', error));
    }
    else alert('The transaction cannot be found');
}

async function addBusinessCategory() {
    let category = {
        name: document.getElementById('add-category-name').value,
        numberOfTransaction: 0,
        totalAmount: 0,
    };

    await fetch(`${uri}/BusinessCategory/Create`, {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(category)
    })
        .then(() => {
            closeModalDiv();
            getBusinessItems();
        })
        .catch(error => console.error('Unable to post category', error));
}

async function editBusinessCategory(id) {
    let category = _categories.find(x => x.id === id);

    if (category != null) {
        category.name = document.getElementById('edit-category-name').value;

        await fetch(`${uri}/BusinessCategory/Edit/${category.id}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(category)
        }).then(() => {
            closeModalDiv();
            getBusinessItems(_section);
        }).catch(error => console.error('Unable to update category', error));
    }
    else alert('The category cannot be found');
}

async function deleteBusinessCategory(id) {
    let category = _categories.find(x => x.id === id);

    if (category != null) {
        if (confirm(`Are you sure you want to delete this category?`))
            await fetch(`${uri}/BusinessCategory/Delete/${id}`, { method: 'DELETE' })
                .then(() => {
                    closeModalDiv();
                    getBusinessItems(_section);
                })
                .catch(error => console.error('Unable to delete category', error));
    }
    else alert('The category cannot be found');
}

async function addBusinessSupplier() {
    let supplier = {
        name: document.getElementById('add-supplier-name').value,
        numberOfTransaction: 0,
        totalAmount: 0,
    };

    await fetch(`${uri}/BusinessSupplier/Create`, {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(supplier)
    })
        .then(() => {
            closeModalDiv();
            getBusinessItems();
        })
        .catch(error => console.error('Unable to post supplier', error));
}

async function editBusinessSupplier(id) {
    let supplier = _suppliers.find(x => x.id === id);

    if (supplier != null) {
        supplier.name = document.getElementById('edit-supplier-name').value;

        await fetch(`${uri}/BusinessSupplier/Edit/${category.id}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(category)
        }).then(() => {
            closeModalDiv();
            getBusinessItems(_section);
        }).catch(error => console.error('Unable to update supplier', error));
    }
    else alert('The supplier cannot be found');
}

async function deleteBusinessSupplier(id) {
    let supplier = _suppliers.find(x => x.id === id);

    if (supplier != null) {
        if (confirm(`Are you sure you want to delete this supplier?`))
            await fetch(`${uri}/BusinessSupplier/Delete/${id}`, { method: 'DELETE' })
                .then(() => {
                    closeModalDiv();
                    getBusinessItems(_section);
                })
                .catch(error => console.error('Unable to delete supplier', error));
    }
    else alert('The supplier cannot be found');
}

async function getCurrentAutoBusinessTransactions() {
    fetch(`${uri}/BusinessTransaction/GetCurrentAutos`)
        .then(res => res.json())
        .then(data => {
            _autos = data;
            _autos.forEach(x => x.category = _categories.find(y => y.id === x.categoryId));
            _autos.forEach(x => x.supplier = _suppliers.find(y => y.id === x.supplierId));
        })
        .catch(error => console.error('Cannot fetch current autos.', error));

}

async function addAutoBusinessTransaction() {
    
    let transaction = {
        name: document.getElementById('auto-add-name').value,
        date: document.getElementById('auto-add-date').value.substring(0, 10),
        amount: document.getElementById('auto-add-amount').value,
        categoryId: document.getElementById('auto-add-category').value,
        supplierId: document.getElementById('auto-add-supplier').value,
    };

    let interval = document.getElementById('auto-add-interval').value;

    await fetch(`${uri}/BusinessTransaction/AddAuto/?interval=${interval}`,
        {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(transaction)
        })
        .then(() => { closeModalDiv(); getBusinessItems(); })
        .catch(error => console.error(error));
}

async function stopAutoBusinessTransaction(id) {
    transaction = _transactions.find(x => x.id === id);
    if (transaction != null) {
        if (confirm(`Are you sure you want to stop the transaction named "${transaction.name}" from recurring?`)) {
            fetch(`${uri}/BusinessTransaction/StopAuto`,
                {
                    method: 'POST',
                    headers: {
                        'Accept': 'application.json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(transaction)
                }).then(() => { closeModalDiv(); openStopAutoBusinessTransaction(); })
                .catch(error => console.error('Unbale to stop the job', error));
        }
    }
    else alert('The transaction cannot be found.');
}

//#endregion

//#region item display

function _displayBusinessItems() {
    if (_lastSection != _section) {
        let mainDiv = document.getElementById('main-div');
        mainDiv.classList.toggle('fadeIn');

        let searchDiv = document.getElementById('nav-search-div');
        searchDiv.classList.toggle('fadeIn');
        let handler = function () {
            mainDiv.classList.remove('fadeIn');
            searchDiv.classList.remove('fadeIn');
        }
        mainDiv.addEventListener('animationend', handler, false);
    }

    if (_section === "businessCategories") _displayBusinessCategories();
    else if (_section === "businessSuppliers") _displayBusinessSuppliers();
    else _displayBusinessTransactions();
}

function _displayBusinessTransactions() {
    // setting used elements
    document.getElementById('section-h1').innerText = 'Business Transactions';

    let thead = document.getElementById('item-table-head');
    thead.innerHTML = '';
    let tbody = document.getElementById('table-body');
    tbody.innerHTML = '';

    let addBtn = document.getElementById('add-btn');
    addBtn.setAttribute('onclick', `openAddBusinessTransaction()`);
    addBtn.addEventListener('pointermove', (evt) => {
        if (_section == 'businessTransactions') {
            let p = document.getElementById('btn-p');
            p.innerText = 'Add one transaction normally.';
            p.style.display = 'inline';
        }
    }, false);

    addBtn.addEventListener('mouseout', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = '';
        p.style.display = 'none';
    }, false);

    let autoAddDiv = document.getElementById('auto-add-div');
    autoAddDiv.style.display = 'inline-block';

    let autoAddBtn = document.getElementById('auto-add-btn');
    autoAddBtn.style.display = 'inline-block';
    autoAddBtn.disabled = false;

    autoAddBtn.setAttribute('onclick', `openAddAutoBusinessTransaction()`);
    autoAddBtn.addEventListener('pointermove', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = 'Add an automatically recurring transaction.';
        p.style.display = 'inline';
    }, false);

    autoAddBtn.addEventListener('mouseout', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = '';
        p.style.display = 'none';
    }, false);

    autoAddBtn.addEventListener('mouseout', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = '';
        p.style.display = 'none';
    }, false);

    let autoStopBtn = document.getElementById('auto-stop-btn');
    autoStopBtn.style.display = 'inline-block';
    autoStopBtn.disabled = false;

    autoStopBtn.setAttribute('onclick', `openStopAutoBusinessTransaction()`);
    autoStopBtn.addEventListener('pointermove', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = 'Stop an automatically recurring transaction additions.';
        p.style.display = 'inline';
    }, false);

    autoStopBtn.addEventListener('mouseout', (evt) => {
        let p = document.getElementById('btn-p');
        p.innerText = '';
        p.style.display = 'none';
    }, false);

    let th = document.createElement('th');
    let htr = thead.insertRow();
    let btn = document.createElement('button');
    let a = document.createElement('a');

    // item display
    let th1 = th.cloneNode(false);
    let idA = a.cloneNode(false);
    idA.innerText = '#';
    idA.id = 'th-a-id';
    idA.classList.add('th-a');
    idA.setAttribute('onclick', `orderBy("id")`);
    th1.appendChild(idA);
    htr.appendChild(th1);

    let th2 = th.cloneNode(false);
    let nameA = a.cloneNode(false);
    nameA.innerText = 'name';
    nameA.id = 'th-a-name';
    nameA.classList.add('th-a');
    nameA.setAttribute('onclick', `orderBy("name")`);
    th2.appendChild(nameA);
    htr.appendChild(th2);

    let th3 = th.cloneNode(false);
    let dateA = a.cloneNode(false);
    dateA.innerText = 'date';
    dateA.id = 'th-a-date';
    dateA.classList.add('th-a');
    dateA.setAttribute('onclick', `orderBy("date")`);
    th3.appendChild(dateA);
    htr.appendChild(th3);

    let th4 = th.cloneNode(false);
    let catA = a.cloneNode(false);
    catA.innerText = 'category';
    catA.id = 'th-a-cat';
    catA.classList.add('th-a');
    catA.setAttribute('onclick', `orderBy("category")`);
    th4.appendChild(catA);
    htr.appendChild(th4);

    let th5 = th.cloneNode(false)
    let suppA = a.cloneNode(false);
    suppA.innerText = 'supplier';
    suppA.id = 'th-a-supp';
    suppA.classList.add('th-a');
    suppA.setAttribute('onclick', `orderBy("supplier")`);
    th5.appendChild(suppA);
    htr.appendChild(th5);

    let th6 = th.cloneNode(false);
    let amountA = a.cloneNode(false);
    amountA.id = 'th-a-amount';
    amountA.innerText = 'amount';
    amountA.classList.add('th-a');
    amountA.setAttribute('onclick', `orderBy("amount")`);
    th6.appendChild(amountA);
    htr.appendChild(th6);

    let th7 = th.cloneNode(false);
    let th8 = th.cloneNode(false);
    htr.appendChild(th7);
    htr.appendChild(th8);
    if (_transactions != null) {
        for (let i = (_currentPage - 1) * 20; i < _transactions.length && i < ((_currentPage - 1) * 20) + 20; i++) {

            item = _transactions[i];

            let tr = tbody.insertRow();
            tr.id = `transaction-tr-${item.Id}`;

            let td1 = tr.insertCell(0);
            let idNode = document.createTextNode(item.id);
            td1.appendChild(idNode);

            let td2 = tr.insertCell(1);
            let nameNode = document.createTextNode(item.name);
            td2.appendChild(nameNode);

            let td3 = tr.insertCell(2);
            let datenode = document.createTextNode(item.date.substring(0, 10));
            td3.appendChild(datenode);

            let td4 = tr.insertCell(3);
            let categoryNode = document.createTextNode(item.category.name);
            td4.appendChild(categoryNode);

            let td5 = tr.insertCell(4);
            let supplierNode = document.createTextNode(item.supplier.name);
            td5.appendChild(supplierNode);

            let td6 = tr.insertCell(5);
            let amountNode = document.createTextNode(new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(item.amount));
            td6.appendChild(amountNode);

            let td7 = tr.insertCell(6);
            td7.classList.add('text-center');
            let editBtn = btn.cloneNode(false);
            editBtn.setAttribute('onclick', `openEditBusinessTransaction(${item.id})`);
            editBtn.classList.add('btn');
            editBtn.classList.add('btn-success');
            editBtn.classList.add('edit-btn');
            td7.appendChild(editBtn);

            let td8 = tr.insertCell(7);
            td8.classList.add('text-center');
            let delBtn = btn.cloneNode(false);
            delBtn.setAttribute('onclick', `openDeleteBusinessTransaction(${item.id})`);
            delBtn.classList.add('btn');
            delBtn.classList.add('btn-danger');
            delBtn.classList.add('del-btn');
            td8.appendChild(delBtn);
        }
    }

    _highlightOrder();
}

function _displayBusinessTransactionSearch() {
    let navForm = document.getElementById('nav-search-form');
    navForm.innerHTML = '';
    navForm.setAttribute('oninput', `searchBusinessTransactions()`);

    let input = document.createElement('input');
    let label = document.createElement('label');
    let option = document.createElement('option');
    let div = document.createElement('div');

    // Name
    let searchNameInput = input.cloneNode(false);
    searchNameInput.value = _businessTransactionSearch.name;
    searchNameInput.classList.add('form-control');
    searchNameInput.classList.add('me-3');
    searchNameInput.id = 'search-transaction-name';
    searchNameInput.placeholder = 'transaction';
    navForm.appendChild(searchNameInput);

    // Date
    let searchDateDiv = div.cloneNode(false);
    searchDateDiv.classList.add('d-inline-flex');
    searchDateDiv.classList.add('justify-content-start');
    searchDateDiv.classList.add('me-3');
    searchDateDiv.ariaLabel = 'Basic checkbox toggle button group';

    let searchDateBox = input.cloneNode(false);
    searchDateBox.checked = _businessTransactionSearch.dateBox;
    searchDateBox.type = 'checkbox';
    searchDateBox.id = 'search-date-box';
    searchDateBox.classList.add('btn-check');
    searchDateBox.autocomplete = 'off';
    searchDateBox.setAttribute('aria-disabled', 'true');
    searchDateDiv.appendChild(searchDateBox);

    let searchDateLabel = label.cloneNode(false);
    searchDateLabel.classList.add('btn');
    searchDateLabel.classList.add('btn-outline-info');
    searchDateLabel.classList.add('me-1');
    searchDateLabel.innerText = 'Date';
    searchDateLabel.setAttribute('for', 'search-date-box');
    searchDateDiv.appendChild(searchDateLabel);

    let searchDateSelect = document.createElement('select');
    searchDateSelect.id = 'search-date-select';
    searchDateSelect.classList.add('btn');
    searchDateSelect.classList.add('btn-outline-info');
    searchDateSelect.ariaLabel = 'Default select';

    let sdsOpt1 = option.cloneNode(false);
    sdsOpt1.value = 'more';
    sdsOpt1.innerText = '>';

    let sdsOpt2 = option.cloneNode(false);
    sdsOpt2.value = 'less';
    sdsOpt2.innerText = '<';

    if (_businessTransactionSearch.dateMode === 'less') sdsOpt2.selected = true; else sdsOpt1.selected = true;
    searchDateSelect.appendChild(sdsOpt1);
    searchDateSelect.appendChild(sdsOpt2);
    searchDateDiv.appendChild(searchDateSelect);

    let searchDateInput = input.cloneNode(false);
    searchDateInput.value = _businessTransactionSearch.date.substring(0, 10);
    searchDateInput.id = 'search-date-input';
    searchDateInput.type = 'date';
    searchDateInput.classList.add('form-control');
    searchDateInput.classList.add('ms-2');
    searchDateDiv.appendChild(searchDateInput);
    navForm.appendChild(searchDateDiv);

    // Amount
    let searchAmountDiv = div.cloneNode(false);
    searchAmountDiv.classList.add('d-inline-flex');
    searchAmountDiv.classList.add('justify-content-start');
    searchAmountDiv.classList.add('me-3');
    searchAmountDiv.ariaLabel = 'Basic checkbox toggle button group';

    let searchAmountBox = input.cloneNode(false);
    searchAmountBox.checked = _businessTransactionSearch.amountBox;
    searchAmountBox.type = 'checkbox';
    searchAmountBox.id = 'search-amount-box';
    searchAmountBox.classList.add('btn-check');
    searchAmountBox.autocomplete = 'off';
    searchAmountDiv.appendChild(searchAmountBox);

    let searchAmountLabel = label.cloneNode(false);
    searchAmountLabel.classList.add('btn');
    searchAmountLabel.classList.add('btn-outline-info');
    searchAmountLabel.classList.add('me-1');
    searchAmountLabel.innerText = 'Amount';
    searchAmountLabel.setAttribute('for', 'search-amount-box');
    searchAmountDiv.appendChild(searchAmountLabel);

    let searchAmountSelect = document.createElement('select');
    searchAmountSelect.id = 'search-amount-select';
    searchAmountSelect.classList.add('btn');
    searchAmountSelect.classList.add('btn-outline-info');
    searchAmountSelect.ariaLabel = 'Default select ';

    let sasOpt1 = option.cloneNode(false);
    sasOpt1.value = 'more';
    sasOpt1.innerText = '>';

    let sasOpt2 = option.cloneNode(false);
    sasOpt2.value = 'less';
    sasOpt2.innerText = '<';

    if (_businessTransactionSearch.amountMode === 'less') sasOpt2.selected = true; else sasOpt1.selected = true;
    searchAmountSelect.appendChild(sasOpt1);
    searchAmountSelect.appendChild(sasOpt2);
    searchAmountDiv.appendChild(searchAmountSelect);

    let searchAmountInput = input.cloneNode(false);
    searchAmountInput.value = _businessTransactionSearch.amount;
    searchAmountInput.id = 'search-amount-input';
    searchAmountInput.type = 'number';
    searchAmountInput.min = '0.1';
    searchAmountInput.max = '5000';
    searchAmountInput.step = '0.1';
    searchAmountInput.style.borderRadius = '4px;';
    searchAmountInput.value = '10';
    searchAmountInput.classList.add('form-control');
    searchAmountInput.classList.add('ms-2');
    searchAmountDiv.appendChild(searchAmountInput);
    navForm.appendChild(searchAmountDiv);

    // Categories
    let searchCategoryDiv = div.cloneNode(false);
    searchCategoryDiv.id = 'search-category-div';
    searchCategoryDiv.classList.add('me-3');

    let searchCategorySelect = document.createElement('select')
    searchCategorySelect.id = 'search-category-select';
    searchCategorySelect.classList.add('form-select');
    searchCategorySelect.classList.add('me-3');
    searchCategorySelect.ariaLabel = 'Default select';

    let defaultOpt = option.cloneNode(false);
    defaultOpt.value = 0;
    defaultOpt.innerText = 'Select Category';
    defaultOpt.selected = true;
    searchCategorySelect.appendChild(defaultOpt);

    _categories.forEach(
        cat => {
            let opt = option.cloneNode(false);
            opt.value = `${cat.id}`;
            opt.innerText = cat.name;
            if (opt.value === _businessTransactionSearch.categoryId) opt.selected = true;
            searchCategorySelect.appendChild(opt);
        }
    );
    searchCategoryDiv.appendChild(searchCategorySelect);
    navForm.appendChild(searchCategoryDiv);

    // Suppliers
    let searchSupplierDiv = div.cloneNode(false);
    searchSupplierDiv.id = 'search-supplier-div';
    searchSupplierDiv.classList.add('me-3');

    let searchSupplierSelect = document.createElement('select')
    searchSupplierSelect.id = 'search-supplier-select';
    searchSupplierSelect.classList.add('form-select');
    searchSupplierSelect.ariaLabel = 'Default select';

    let defaultSupplierOpt = option.cloneNode(false);
    defaultSupplierOpt.value = 0;
    defaultSupplierOpt.innerText = 'Select Supplier';
    defaultSupplierOpt.selected = true;
    searchSupplierSelect.appendChild(defaultSupplierOpt);

    _suppliers.forEach(
        sup => {
            let opt = option.cloneNode(false);
            opt.value = `${sup.id}`;
            opt.innerText = sup.name;
            if (opt.value === _businessTransactionSearch.supplierId) opt.selected = true;
            searchSupplierSelect.appendChild(opt);
        }
    );
    searchSupplierDiv.appendChild(searchSupplierSelect);
    navForm.appendChild(searchSupplierDiv);

    // recurrent
    let recurDiv = div.cloneNode(false);
    recurDiv.id = 'search-recurrent-div';
    recurDiv.classList.add('me-3');

    let recurSelect = document.createElement('select');
    recurSelect.id = 'search-recurrent-select';
    recurSelect.classList.add('form-select');
    recurSelect.ariaLabel = 'Default recur select';

    let defRecurOpt = option.cloneNode(false);
    defRecurOpt.value = 0;
    defRecurOpt.innerText = 'All';
    defRecurOpt.selected = true;
    recurSelect.appendChild(defRecurOpt);

    let normRecurOpt = option.cloneNode(false);
    normRecurOpt.value = 1;
    normRecurOpt.innerText = 'Normal';
    recurSelect.appendChild(normRecurOpt);

    let recuRecurOpt = option.cloneNode(false);
    recuRecurOpt.value = 2;
    recuRecurOpt.innerText = 'Recurrent';
    recurSelect.appendChild(recuRecurOpt);

    recurDiv.appendChild(recurSelect);
    navForm.appendChild(recurDiv);
}

function _displayBusinessCategories() {
    let autoAddDiv = document.getElementById('auto-add-div');
    autoAddDiv.style.display = 'none';

    let autoStopBtn = document.getElementById('auto-stop-btn');
    autoStopBtn.style.display = 'none';
    autoStopBtn.disabled = true;
    autoStopBtn.setAttribute('onclick', '');

    let autoAddBtn = document.getElementById('auto-add-btn');
    autoAddBtn.style.display = 'none';
    autoAddBtn.disabled = true;
    autoAddBtn.setAttribute('onclick', '');

    _businessTransactionSearch = {
        name: '',
        dateBox: false,
        dateMode: 'more',
        date: new Date(Date.now()).toISOString().slice(0, 10),
        amountBox: false,
        amountMode: 'more',
        amount: 0,
        categoryId: 0,
        supplierId: 0,
    };
    _currentPage = 1;

    let ul = document.getElementById('page-ul');
    ul.innerHTML = '';

    document.getElementById('section-h1').innerText = 'Business Categories';
    let thead = document.getElementById('item-table-head');
    thead.innerHTML = '';
    let tbody = document.getElementById('table-body');
    tbody.innerHTML = '';
    let addBtn = document.getElementById('add-btn');
    addBtn.setAttribute('onclick', `openAddBusinessCategory()`);

    let th = document.createElement('th');
    let htr = thead.insertRow();
    let btn = document.createElement('button');

    let th1 = th.cloneNode(false);
    th1.innerText = '#';
    htr.appendChild(th1);

    let th2 = th.cloneNode(false);
    th2.innerText = 'Name';
    htr.appendChild(th2);

    let th3 = th.cloneNode(false);
    th3.innerText = 'Number of Transactions';
    htr.appendChild(th3);

    let th4 = th.cloneNode(false);
    th4.innerText = 'Total Amount';
    htr.appendChild(th4);

    let th5 = th.cloneNode(false);
    htr.appendChild(th5);

    let th6 = th.cloneNode(false);
    htr.appendChild(th6);

    _categories.forEach(item => {
        let tr = tbody.insertRow();
        tr.id = `catgory-tr-${item.Id}`;

        let td1 = tr.insertCell(0);
        let idNode = document.createTextNode(item.id);
        td1.appendChild(idNode);

        let td2 = tr.insertCell(1);
        let nameNode = document.createTextNode(item.name);
        td2.appendChild(nameNode);

        let td3 = tr.insertCell(2);
        let transactionNode = document.createTextNode(item.numberOfTransaction);
        td3.appendChild(transactionNode);

        let td4 = tr.insertCell(3);
        let amountNode = document.createTextNode(new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(item.totalAmount));
        td4.appendChild(amountNode);

        let td5 = tr.insertCell(4);
        td5.classList.add('text-center');
        let editBtn = btn.cloneNode(false);
        editBtn.setAttribute('onclick', `openEditBusinessCategory(${item.id})`);
        editBtn.classList.add('btn');
        editBtn.classList.add('btn-success');
        editBtn.classList.add('edit-btn');
        editBtn.innerText = 'Edit';
        td5.appendChild(editBtn);

        let td6 = tr.insertCell(5);
        td6.classList.add('text-center');
        let delBtn = btn.cloneNode(false);
        delBtn.setAttribute('onclick', `openDeleteBusinessCategory(${item.id})`);
        delBtn.classList.add('btn');
        delBtn.classList.add('btn-danger');
        delBtn.classList.add('del-btn');
        delBtn.innerText = 'Del';
        td6.appendChild(delBtn);
    })
}

function _displayBusinessSuppliers() {
    let autoAddDiv = document.getElementById('auto-add-div');
    autoAddDiv.style.display = 'none';

    let autoStopBtn = document.getElementById('auto-stop-btn');
    autoStopBtn.style.display = 'none';
    autoStopBtn.disabled = true;
    autoStopBtn.setAttribute('onclick', '');

    let autoAddBtn = document.getElementById('auto-add-btn');
    autoAddBtn.style.display = 'none';
    autoAddBtn.disabled = true;
    autoAddBtn.setAttribute('onclick', '');

    _businessTransactionSearch = {
        name: '',
        dateBox: false,
        dateMode: 'more',
        date: new Date(Date.now()).toISOString().slice(0, 10),
        amountBox: false,
        amountMode: 'more',
        amount: 0,
        categoryId: 0,
        supplierId: 0,
    };
    _currentPage = 1;

    let ul = document.getElementById('page-ul');
    ul.innerHTML = '';

    document.getElementById('section-h1').innerText = 'Business Suppliers';
    let thead = document.getElementById('item-table-head');
    thead.innerHTML = '';
    let tbody = document.getElementById('table-body');
    tbody.innerHTML = '';
    let addBtn = document.getElementById('add-btn');
    addBtn.setAttribute('onclick', `openAddBusinessSupplier()`);

    let th = document.createElement('th');
    let htr = thead.insertRow();
    let btn = document.createElement('button');

    let th1 = th.cloneNode(false);
    th1.innerText = '#';
    htr.appendChild(th1);

    let th2 = th.cloneNode(false);
    th2.innerText = 'Name';
    htr.appendChild(th2);

    let th3 = th.cloneNode(false);
    th3.innerText = 'Number of Transactions';
    htr.appendChild(th3);

    let th4 = th.cloneNode(false);
    th4.innerText = 'Total Amount';
    htr.appendChild(th4);

    let th5 = th.cloneNode(false);
    htr.appendChild(th5);

    let th6 = th.cloneNode(false);
    htr.appendChild(th6);

    _suppliers.forEach(item => {
        let tr = tbody.insertRow();
        tr.id = `supplier-tr-${item.Id}`;

        let td1 = tr.insertCell(0);
        let idNode = document.createTextNode(item.id);
        td1.appendChild(idNode);

        let td2 = tr.insertCell(1);
        let nameNode = document.createTextNode(item.name);
        td2.appendChild(nameNode);

        let td3 = tr.insertCell(2);
        let transactionNode = document.createTextNode(item.numberOfTransaction);
        td3.appendChild(transactionNode);

        let td4 = tr.insertCell(3);
        let amountNode = document.createTextNode(new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(item.totalAmount));
        td4.appendChild(amountNode);

        let td5 = tr.insertCell(4);
        td5.classList.add('text-center');
        let editBtn = btn.cloneNode(false);
        editBtn.setAttribute('onclick', `openEditBusinessSupplier(${item.id})`);
        editBtn.classList.add('btn');
        editBtn.classList.add('btn-success');
        editBtn.classList.add('edit-btn');
        editBtn.innerText = 'Edit';
        td5.appendChild(editBtn);

        let td6 = tr.insertCell(5);
        td6.classList.add('text-center');
        let delBtn = btn.cloneNode(false);
        delBtn.setAttribute('onclick', `openDeleteBusinessSupplier(${item.id})`);
        delBtn.classList.add('btn');
        delBtn.classList.add('btn-danger');
        delBtn.classList.add('del-btn');
        delBtn.innerText = 'Del';
        td6.appendChild(delBtn);
    });
}

//#endregion

//#region post display

function openAddBusinessTransaction() {
    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let btn = document.createElement('button');
    let option = document.createElement('option');

    let addDiv = document.createElement('div');
    addDiv.id = 'add-div';
    addDiv.classList.add('ms-2');
    addDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'post';
    form.setAttribute('onsubmit', `addBusinessTransaction()`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.innerText = 'Name: ';
    nameLabel.classList.add('form-label');
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.placeholder = 'New transaction';
    nameInput.type = 'text';
    nameInput.id = 'transaction-add-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Date
    let dateDiv = div.cloneNode(false);
    let dateLabel = label.cloneNode(false);
    dateLabel.innerText = 'Date: ';
    dateLabel.classList.add('form-label');
    dateDiv.appendChild(dateLabel);

    let dateInput = input.cloneNode(false);
    dateInput.type = 'date';
    dateInput.id = 'transaction-add-date';
    dateInput.classList.add('form-control');
    dateInput.required = true;
    dateDiv.appendChild(dateInput);
    form.appendChild(dateDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.innerText = 'Amount: ';
    amountLabel.classList.add('form-label');
    amountDiv.appendChild(amountLabel);

    let amountInput = input.cloneNode(false);
    amountInput.type = 'number';
    amountInput.step = '0.01';
    amountInput.id = 'transaction-add-amount';
    amountInput.classList.add('form-control');
    amountInput.required = true;
    amountInput.min = '0.01';
    amountInput.max = '5000';
    amountDiv.appendChild(amountInput);
    form.appendChild(amountDiv);

    // Category
    let categoryDiv = div.cloneNode(false);
    let categoryLabel = label.cloneNode(false);
    categoryLabel.innerText = 'Category: ';
    categoryLabel.classList.add('form-label');
    categoryDiv.appendChild(categoryLabel);

    let categoryInput = document.createElement('select');
    categoryInput.id = 'transaction-add-category';
    categoryInput.classList.add('form-control');

    _categories.forEach(cat => {
        let opt = option.cloneNode(false);
        opt.value = cat.id;
        opt.innerText = cat.name;
        categoryInput.appendChild(opt);
    })

    categoryDiv.appendChild(categoryInput);
    form.appendChild(categoryDiv);

    // Supplier
    let supplierDiv = div.cloneNode(false);
    let supplierLabel = label.cloneNode(false);
    supplierLabel.innerText = 'Supplier: ';
    supplierLabel.classList.add('form-label');
    supplierDiv.appendChild(supplierLabel);

    let supplierInput = document.createElement('select');
    supplierInput.id = 'transaction-add-supplier';
    supplierInput.classList.add('form-control');

    _suppliers.forEach(sup => {
        let opt = option.cloneNode(false);
        opt.value = sup.id;
        opt.innerText = sup.name;
        supplierInput.appendChild(opt);
    })

    supplierDiv.appendChild(supplierInput);
    form.appendChild(supplierDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let addBtn = btn.cloneNode(false);
    addBtn.type = 'submit';
    addBtn.classList.add('btn');
    addBtn.classList.add('btn-info');
    addBtn.classList.add('me-2');

    addBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>
    <g id="SVGRepo_iconCarrier"> <path d="M15 12L12 12M12 12L9 12M12 12L12 9M12 12L12 15" stroke="orange" stroke-width="1.5" stroke-linecap="round"/> <path d="M22 12C22 16.714 22 19.0711 20.5355 20.5355C19.0711 22 16.714 22 12 22C7.28595 22 4.92893 22 3.46447 20.5355C2 19.0711 2 16.714 2 12C2 7.28595 2 4.92893 3.46447 3.46447C4.92893 2 7.28595 2 12 2C16.714 2 19.0711 2 20.5355 3.46447C21.5093 4.43821 21.8356 5.80655 21.9449 8" stroke="#fff" stroke-width="1.5" stroke-linecap="round"/> </g>
    </svg>`;

    btnDiv.appendChild(addBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    addDiv.appendChild(form);
    modalDiv.appendChild(addDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openAddBusinessCategory() {
    let btn = document.createElement('button');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let span = document.createElement('span');

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let editDiv = div.cloneNode(false);
    editDiv.id = 'edit-div';
    editDiv.classList.add('ms-2');
    editDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'put';
    form.setAttribute('onsubmit', `addBusinessCategory()`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.classList.add('form-label');
    nameLabel.classList.add('me-2');
    nameLabel.innerText = 'Name:';
    nameLabel.for = 'add-category-name';
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.value = '';
    nameInput.placeholder = 'New Category';
    nameInput.type = 'text';
    nameInput.id = 'add-category-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Transactions
    let transactionDiv = div.cloneNode(false);
    let transactionLabel = label.cloneNode(false);
    transactionLabel.classList.add('form-label');
    transactionLabel.classList.add('me-2');
    transactionLabel.classList.add('mt-2');
    transactionLabel.innerText = 'Number of Transaction:';
    transactionLabel.for = 'add-category-transactions';
    transactionDiv.appendChild(transactionLabel);

    let transactionSpan = span.cloneNode(false);
    transactionSpan.innerText = 0;
    transactionSpan.id = 'add-category-transactions';
    transactionSpan.classList.add('form-control');
    transactionDiv.appendChild(transactionSpan);
    form.appendChild(transactionDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.classList.add('form-label');
    amountLabel.classList.add('me-2');
    amountLabel.classList.add('mt-2');
    amountLabel.innerText = 'Total Amount:';
    amountLabel.for = 'add-category-amount';
    amountDiv.appendChild(amountLabel);

    let amountSpan = span.cloneNode(false);
    amountSpan.innerText = 0;
    amountSpan.id = 'add-category-amount';
    amountSpan.classList.add('form-control');
    amountDiv.appendChild(amountSpan);
    form.appendChild(amountDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let addBtn = btn.cloneNode(false);
    addBtn.type = 'submit';
    addBtn.classList.add('btn');
    addBtn.classList.add('btn-info');
    addBtn.classList.add('me-2');

    addBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>
    <g id="SVGRepo_iconCarrier"> <path d="M15 12L12 12M12 12L9 12M12 12L12 9M12 12L12 15" stroke="orange" stroke-width="1.5" stroke-linecap="round"/> <path d="M22 12C22 16.714 22 19.0711 20.5355 20.5355C19.0711 22 16.714 22 12 22C7.28595 22 4.92893 22 3.46447 20.5355C2 19.0711 2 16.714 2 12C2 7.28595 2 4.92893 3.46447 3.46447C4.92893 2 7.28595 2 12 2C16.714 2 19.0711 2 20.5355 3.46447C21.5093 4.43821 21.8356 5.80655 21.9449 8" stroke="#fff" stroke-width="1.5" stroke-linecap="round"/> </g>
    </svg>`;

    btnDiv.appendChild(addBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('cn-btn');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    editDiv.appendChild(form);
    modalDiv.appendChild(editDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openAddBusinessSupplier() {
    let btn = document.createElement('button');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let span = document.createElement('span');

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let editDiv = div.cloneNode(false);
    editDiv.id = 'edit-div';
    editDiv.classList.add('ms-2');
    editDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'put';
    form.setAttribute('onsubmit', `addBusinessSupplier()`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.classList.add('form-label');
    nameLabel.classList.add('me-2');
    nameLabel.innerText = 'Name:';
    nameLabel.for = 'add-supplier-name';
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.value = '';
    nameInput.placeholder = 'New Category';
    nameInput.type = 'text';
    nameInput.id = 'add-supplier-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Transaction
    let transactionDiv = div.cloneNode(false);
    let transactionLabel = label.cloneNode(false);
    transactionLabel.classList.add('form-label');
    transactionLabel.classList.add('me-2');
    transactionLabel.classList.add('mt-2');
    transactionLabel.innerText = 'Number of Transaction:';
    transactionLabel.for = 'add-suppler-transactions';
    transactionDiv.appendChild(transactionLabel);

    let transactionSpan = span.cloneNode(false);
    transactionSpan.innerText = 0;
    transactionSpan.id = 'add-suplier-transactions';
    transactionSpan.classList.add('form-control');
    transactionDiv.appendChild(transactionSpan);
    form.appendChild(transactionDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.classList.add('form-label');
    amountLabel.classList.add('me-2');
    amountLabel.classList.add('mt-2');
    amountLabel.innerText = 'Total Amount:';
    amountLabel.for = 'add-supplier-amount';
    amountDiv.appendChild(amountLabel);

    let amountSpan = span.cloneNode(false);
    amountSpan.innerText = 0;
    amountSpan.id = 'add-supplier-amount';
    amountSpan.classList.add('form-control');
    amountDiv.appendChild(amountSpan);
    form.appendChild(amountDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let addBtn = btn.cloneNode(false);
    addBtn.type = 'submit';
    addBtn.classList.add('btn');
    addBtn.classList.add('btn-info');
    addBtn.classList.add('me-2');

    addBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>
    <g id="SVGRepo_iconCarrier"> <path d="M15 12L12 12M12 12L9 12M12 12L12 9M12 12L12 15" stroke="orange" stroke-width="1.5" stroke-linecap="round"/> <path d="M22 12C22 16.714 22 19.0711 20.5355 20.5355C19.0711 22 16.714 22 12 22C7.28595 22 4.92893 22 3.46447 20.5355C2 19.0711 2 16.714 2 12C2 7.28595 2 4.92893 3.46447 3.46447C4.92893 2 7.28595 2 12 2C16.714 2 19.0711 2 20.5355 3.46447C21.5093 4.43821 21.8356 5.80655 21.9449 8" stroke="#fff" stroke-width="1.5" stroke-linecap="round"/> </g>
    </svg>`;

    btnDiv.appendChild(addBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('cn-btn');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    editDiv.appendChild(form);
    modalDiv.appendChild(editDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openAddAutoBusinessTransaction() {
    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let btn = document.createElement('button');
    let option = document.createElement('option');

    let addDiv = document.createElement('div');
    addDiv.id = 'add-div';
    addDiv.classList.add('ms-2');
    addDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'post';
    form.setAttribute('onsubmit', `addAutoBusinessTransaction()`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.innerText = 'Name: ';
    nameLabel.classList.add('form-label');
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.placeholder = 'New transaction';
    nameInput.type = 'text';
    nameInput.id = 'auto-add-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Date
    let dateDiv = div.cloneNode(false);
    let dateLabel = label.cloneNode(false);
    dateLabel.innerText = 'Date: ';
    dateLabel.classList.add('form-label');
    dateDiv.appendChild(dateLabel);

    let dateInput = input.cloneNode(false);
    dateInput.type = 'date';
    dateInput.id = 'auto-add-date';
    dateInput.classList.add('form-control');
    dateInput.required = true;
    dateDiv.appendChild(dateInput);
    form.appendChild(dateDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.innerText = 'Amount: ';
    amountLabel.classList.add('form-label');
    amountDiv.appendChild(amountLabel);

    let amountInput = input.cloneNode(false);
    amountInput.type = 'number';
    amountInput.step = '0.01';
    amountInput.id = 'auto-add-amount';
    amountInput.classList.add('form-control');
    amountInput.required = true;
    amountInput.min = '0.01';
    amountInput.max = '5000';
    amountDiv.appendChild(amountInput);
    form.appendChild(amountDiv);

    // Category
    let categoryDiv = div.cloneNode(false);
    let categoryLabel = label.cloneNode(false);
    categoryLabel.innerText = 'Category: ';
    categoryLabel.classList.add('form-label');
    categoryDiv.appendChild(categoryLabel);

    let categoryInput = document.createElement('select');
    categoryInput.id = 'auto-add-category';
    categoryInput.classList.add('form-control');

    _categories.forEach(cat => {
        let opt = option.cloneNode(false);
        opt.value = cat.id;
        opt.innerText = cat.name;
        categoryInput.appendChild(opt);
    })

    categoryDiv.appendChild(categoryInput);
    form.appendChild(categoryDiv);

    // Supplier
    let supplierDiv = div.cloneNode(false);
    let supplierLabel = label.cloneNode(false);
    supplierLabel.innerText = 'Supplier: ';
    supplierLabel.classList.add('form-label');
    supplierDiv.appendChild(supplierLabel);

    let supplierInput = document.createElement('select');
    supplierInput.id = 'auto-add-supplier';
    supplierInput.classList.add('form-control');

    _suppliers.forEach(sup => {
        let opt = option.cloneNode(false);
        opt.value = sup.id;
        opt.innerText = sup.name;
        supplierInput.appendChild(opt);
    })

    supplierDiv.appendChild(supplierInput);
    form.appendChild(supplierDiv);

    // Interval
    let intervalDiv = div.cloneNode(false);
    let intervalLabel = label.cloneNode(false);
    intervalLabel.innerText = 'Interval(in secondes)';
    intervalLabel.classList.add('form-label');
    intervalDiv.appendChild(intervalLabel);

    let intervalInput = input.cloneNode(false);
    intervalInput.id = 'auto-add-interval';
    intervalInput.classList.add('form-control');
    intervalInput.tyoe = "number";
    intervalInput.min = 10;
    intervalInput.max = 3600;
    intervalInput.step = "1";
    intervalInput.required = true;
    intervalDiv.appendChild(intervalInput);
    form.appendChild(intervalDiv);
    

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let addBtn = btn.cloneNode(false);
    addBtn.type = 'submit';
    addBtn.classList.add('btn');
    addBtn.classList.add('btn-info');
    addBtn.classList.add('me-2');

    addBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>
    <g id="SVGRepo_iconCarrier"> <path d="M15 12L12 12M12 12L9 12M12 12L12 9M12 12L12 15" stroke="orange" stroke-width="1.5" stroke-linecap="round"/> <path d="M22 12C22 16.714 22 19.0711 20.5355 20.5355C19.0711 22 16.714 22 12 22C7.28595 22 4.92893 22 3.46447 20.5355C2 19.0711 2 16.714 2 12C2 7.28595 2 4.92893 3.46447 3.46447C4.92893 2 7.28595 2 12 2C16.714 2 19.0711 2 20.5355 3.46447C21.5093 4.43821 21.8356 5.80655 21.9449 8" stroke="#fff" stroke-width="1.5" stroke-linecap="round"/> </g>
    </svg>`;

    btnDiv.appendChild(addBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    addDiv.appendChild(form);
    modalDiv.appendChild(addDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openStopAutoBusinessTransaction()
{
    getCurrentAutoBusinessTransactions();

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let btn = document.createElement('button');
    let option = document.createElement('option');
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    let th = document.createElement('th');

    let tableDiv = div.cloneNode(false);
    tableDiv.classList.add('table-responsive');
    tableDiv.style.maxWidth = '80%';
    tableDiv.style.maxHeigth = '70%';
    tableDiv.id = 'stop-auto-div';

    let table = document.createElement('table');
    table.classList.add('table');
    table.classList.add('table-bordered');
    table.classList.add('table-dark');
    table.classList.add('table-striped-columns');
    table.classList.add('table-hover');

    let thead = document.createElement('thead');
    thead.classList.add('table-secondary');
    thead.classList.add('sticky-top');

    let idTh = th.cloneNode(false);
    let idTn = document.createTextNode('#');
    idTh.classList.add('th-a');
    idTh.appendChild(idTn);
    thead.appendChild(idTh);

    let nameTh = th.cloneNode(false);
    let nameTn = document.createTextNode('Name');
    nameTh.classList.add('th-a');
    nameTh.appendChild(nameTn);
    thead.appendChild(nameTh);

    let dateTh = th.cloneNode(false);
    let dateTn = document.createTextNode('Date');
    dateTh.classList.add('th-a');
    dateTh.appendChild(dateTn);
    thead.appendChild(dateTh);

    let catTh = th.cloneNode(false);
    let catTn = document.createTextNode('Category');
    catTh.classList.add('th-a');
    catTh.appendChild(catTn);
    thead.appendChild(catTh);

    let suppTh = th.cloneNode(false);
    let suppTn = document.createTextNode('Supplier');
    suppTh.classList.add('th-a');
    suppTh.appendChild(suppTn);
    thead.appendChild(suppTh);

    let amountTh = th.cloneNode(false);
    let amountTn = document.createTextNode('Amount');
    amountTh.classList.add('th-a');
    amountTh.appendChild(amountTn);
    thead.appendChild(amountTh);

    let btnTh1 = th.cloneNode(false);
    thead.appendChild(btnTh1);
    table.appendChild(thead);

    let tbody = document.createElement('tbody');
    tbody.classList.add('table-group-divider');

    if (_autos != null) {
        _autos.forEach(item => {

            let tr = tbody.insertRow();
            tr.id = `transaction-tr-${item.Id}`;

            let td1 = tr.insertCell(0);
            let idNode = document.createTextNode(item.id);
            td1.appendChild(idNode);

            let td2 = tr.insertCell(1);
            let nameNode = document.createTextNode(item.name);
            td2.appendChild(nameNode);

            let td3 = tr.insertCell(2);
            let datenode = document.createTextNode(item.date.substring(0, 10));
            td3.appendChild(datenode);

            let td4 = tr.insertCell(3);
            let categoryNode = document.createTextNode(item.category.name);
            td4.appendChild(categoryNode);

            let td5 = tr.insertCell(4);
            let supplierNode = document.createTextNode(item.supplier.name);
            td5.appendChild(supplierNode);

            let td6 = tr.insertCell(5);
            let amountNode = document.createTextNode(new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(item.amount));
            td6.appendChild(amountNode);

            let td7 = tr.insertCell(6);
            let editBtn = btn.cloneNode(false);
            editBtn.setAttribute('onclick', `stopAutoBusinessTransaction(${item.id})`);
            editBtn.classList.add('btn');
            editBtn.classList.add('btn-danger');
            editBtn.classList.add('del-btn');
            td7.appendChild(editBtn);
        });
    }
    table.appendChild(tbody);
    tableDiv.appendChild(table);
    modalDiv.appendChild(tableDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

//#endregion

//#region edit display

function openEditBusinessTransaction(id) {
    if (!_transactionExists(id)) {
        alert('This transaction cannot be found');
        return;
    }

    let transaction = _transactions.find(x => x.id === id);

    let label = document.createElement('label');
    let input = document.createElement('input');
    let btn = document.createElement('button');
    let option = document.createElement('option');

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let editDiv = div.cloneNode(false);
    editDiv.id = 'edit-div';
    editDiv.classList.add('ms-2');
    editDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'put';
    form.setAttribute('onsubmit', `editBusinessTransaction(${id})`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.innerText = 'Name: ';
    nameLabel.classList.add('form-label');
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.value = transaction.name;
    nameInput.type = 'text';
    nameInput.id = 'transaction-edit-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Date
    let dateDiv = div.cloneNode(false);
    let dateLabel = label.cloneNode(false);
    dateLabel.innerText = 'Date: ';
    dateLabel.classList.add('form-label');
    dateDiv.appendChild(dateLabel);

    let dateInput = input.cloneNode(false);
    dateInput.value = transaction.date.substring(0, 10);
    dateInput.type = 'date';
    dateInput.id = 'transaction-edit-date';
    dateInput.classList.add('form-control');
    dateInput.required = true;
    dateDiv.appendChild(dateInput);
    form.appendChild(dateDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.innerText = 'Amount: ';
    amountLabel.classList.add('form-label');
    amountDiv.appendChild(amountLabel);

    let amountInput = input.cloneNode(false);
    amountInput.value = transaction.amount;
    amountInput.type = 'number';
    amountInput.step = '0.01';
    amountInput.id = 'transaction-edit-amount';
    amountInput.classList.add('form-control');
    amountInput.required = true;
    amountInput.min = '0';
    amountInput.max = '5000';
    amountDiv.appendChild(amountInput);
    form.appendChild(amountDiv);

    // Category
    let categoryDiv = div.cloneNode(false);
    let categoryLabel = label.cloneNode(false);
    categoryLabel.innerText = 'Category: ';
    categoryLabel.classList.add('form-label');
    categoryDiv.appendChild(categoryLabel);

    let categoryInput = document.createElement('select');
    categoryInput.id = 'transaction-edit-category';
    categoryInput.classList.add('form-control');

    _categories.forEach(cat => {
        let opt = option.cloneNode(false);
        opt.value = cat.id;
        opt.innerText = cat.name;
        if (cat.id === transaction.categoryId) opt.selected = true;
        categoryInput.appendChild(opt);
    })

    categoryDiv.appendChild(categoryInput);
    form.appendChild(categoryDiv);

    // Supplier
    let supplierDiv = div.cloneNode(false);
    let supplierLabel = label.cloneNode(false);
    supplierLabel.innerText = 'Supplier: ';
    supplierLabel.classList.add('form-label');
    supplierDiv.appendChild(supplierLabel);

    let supplierInput = document.createElement('select');
    supplierInput.id = 'transaction-edit-supplier';
    supplierInput.classList.add('form-control');

    _suppliers.forEach(sup => {
        let opt = option.cloneNode(false);
        opt.value = sup.id;
        opt.innerText = sup.name;
        if (sup.id === transaction.supplierId) opt.selected = true;
        supplierInput.appendChild(opt);
    })

    supplierDiv.appendChild(supplierInput);
    form.appendChild(supplierDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let editBtn = btn.cloneNode(false);
    editBtn.type = 'submit';
    editBtn.classList.add('btn');
    editBtn.classList.add('btn-success');
    editBtn.classList.add('edit-btn');
    editBtn.classList.add('me-2');

    editBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <path d="M21.2799 6.40005L11.7399 15.94C10.7899 16.89 7.96987 17.33 7.33987 16.7C6.70987 16.07 7.13987 13.25 8.08987 12.3L17.6399 2.75002C17.8754 2.49308 18.1605 2.28654 18.4781 2.14284C18.7956 1.99914 19.139 1.92124 19.4875 1.9139C19.8359 1.90657 20.1823 1.96991 20.5056 2.10012C20.8289 2.23033 21.1225 2.42473 21.3686 2.67153C21.6147 2.91833 21.8083 3.21243 21.9376 3.53609C22.0669 3.85976 22.1294 4.20626 22.1211 4.55471C22.1128 4.90316 22.0339 5.24635 21.8894 5.5635C21.7448 5.88065 21.5375 6.16524 21.2799 6.40005V6.40005Z" stroke="orange" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    <path d="M11 4H6C4.93913 4 3.92178 4.42142 3.17163 5.17157C2.42149 5.92172 2 6.93913 2 8V18C2 19.0609 2.42149 20.0783 3.17163 20.8284C3.92178 21.5786 4.93913 22 6 22H17C19.21 22 20 20.2 20 18V13" stroke="#ffffff" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    </svg>`;

    btnDiv.appendChild(editBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('cn-btn');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    editDiv.appendChild(form);
    modalDiv.appendChild(editDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openEditBusinessCategory(id) {
    if (!_categoryExists(id)) {
        alert('This category cannot be found');
        return;
    }

    let category = _categories.find(x => x.id === id);

    let btn = document.createElement('button');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let span = document.createElement('span');

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let editDiv = div.cloneNode(false);
    editDiv.id = 'edit-div';
    editDiv.classList.add('ms-2');
    editDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'put';
    form.setAttribute('onsubmit', `editBusinessCategory(${id})`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.classList.add('form-label');
    nameLabel.classList.add('me-2');
    nameLabel.innerText = 'Name:';
    nameLabel.for = 'edit-category-name';
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.value = category.name;
    nameInput.type = 'text';
    nameInput.id = 'edit-category-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Transaction
    let transactionDiv = div.cloneNode(false);
    let transactionLabel = label.cloneNode(false);
    transactionLabel.classList.add('form-label');
    transactionLabel.classList.add('me-2');
    transactionLabel.classList.add('mt-2');
    transactionLabel.innerText = 'Number of Transaction:';
    transactionLabel.for = 'edit-category-transactions';
    transactionDiv.appendChild(transactionLabel);

    let transactionSpan = span.cloneNode(false);
    transactionSpan.innerText = category.numberOfTransaction;
    transactionSpan.id = 'edit-category-transactions';
    transactionSpan.classList.add('form-control');
    transactionDiv.appendChild(transactionSpan);
    form.appendChild(transactionDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.classList.add('form-label');
    amountLabel.classList.add('me-2');
    amountLabel.classList.add('mt-2');
    amountLabel.innerText = 'Total Amount:';
    amountLabel.for = 'edit-category-amount';
    amountDiv.appendChild(amountLabel);

    let amountSpan = span.cloneNode(false);
    amountSpan.innerText = category.totalAmount;
    amountSpan.id = 'edit-category-amount';
    amountSpan.classList.add('form-control');
    amountDiv.appendChild(amountSpan);
    form.appendChild(amountDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let editBtn = btn.cloneNode(false);
    editBtn.type = 'submit';
    editBtn.classList.add('btn');
    editBtn.classList.add('btn-success');
    editBtn.classList.add('edit-btn');
    editBtn.classList.add('me-2');

    editBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <path d="M21.2799 6.40005L11.7399 15.94C10.7899 16.89 7.96987 17.33 7.33987 16.7C6.70987 16.07 7.13987 13.25 8.08987 12.3L17.6399 2.75002C17.8754 2.49308 18.1605 2.28654 18.4781 2.14284C18.7956 1.99914 19.139 1.92124 19.4875 1.9139C19.8359 1.90657 20.1823 1.96991 20.5056 2.10012C20.8289 2.23033 21.1225 2.42473 21.3686 2.67153C21.6147 2.91833 21.8083 3.21243 21.9376 3.53609C22.0669 3.85976 22.1294 4.20626 22.1211 4.55471C22.1128 4.90316 22.0339 5.24635 21.8894 5.5635C21.7448 5.88065 21.5375 6.16524 21.2799 6.40005V6.40005Z" stroke="orange" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    <path d="M11 4H6C4.93913 4 3.92178 4.42142 3.17163 5.17157C2.42149 5.92172 2 6.93913 2 8V18C2 19.0609 2.42149 20.0783 3.17163 20.8284C3.92178 21.5786 4.93913 22 6 22H17C19.21 22 20 20.2 20 18V13" stroke="#ffffff" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    </svg>`;

    btnDiv.appendChild(editBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('cn-btn');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    editDiv.appendChild(form);
    modalDiv.appendChild(editDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openEditBusinessSupplier(id) {
    if (!_supplierExists(id)) {
        alert('This supplier cannot be found');
        return;
    }

    let supplier = _suppliers.find(x => x.id === id);

    let btn = document.createElement('button');
    let label = document.createElement('label');
    let input = document.createElement('input');
    let span = document.createElement('span');

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let div = document.createElement('div');
    let editDiv = div.cloneNode(false);
    editDiv.id = 'edit-div';
    editDiv.classList.add('ms-2');
    editDiv.classList.add('me-2');

    let form = document.createElement('form');
    form.action = 'javascript:void(0)';
    form.method = 'put';
    form.setAttribute('onsubmit', `editBusinessSupplier(${id})`);

    form.classList.add('d-inline-flex');
    form.classList.add('justify-content-between');
    form.classList.add('align-items-end');
    form.classList.add('flex-row');;
    form.style.width = '90%';
    form.style.height = '80%';

    // Name
    let nameDiv = div.cloneNode(false);
    let nameLabel = label.cloneNode(false);
    nameLabel.classList.add('form-label');
    nameLabel.classList.add('me-2');
    nameLabel.innerText = 'Name:';
    nameLabel.for = 'edit-supplier-name';
    nameDiv.appendChild(nameLabel);

    let nameInput = input.cloneNode(false);
    nameInput.value = supplier.name;
    nameInput.type = 'text';
    nameInput.id = 'edit-supplier-name';
    nameInput.classList.add('form-control');
    nameInput.required = true;
    nameInput.minLength = '3';
    nameInput.maxLength = '30';
    nameDiv.appendChild(nameInput);
    form.appendChild(nameDiv);

    // Transaction
    let transactionDiv = div.cloneNode(false);
    let transactionLabel = label.cloneNode(false);
    transactionLabel.classList.add('form-label');
    transactionLabel.classList.add('me-2');
    transactionLabel.classList.add('mt-2');
    transactionLabel.innerText = 'Number of Transaction:';
    transactionLabel.for = 'edit-supplier-transactions';
    transactionDiv.appendChild(transactionLabel);

    let transactionSpan = span.cloneNode(false);
    transactionSpan.innerText = supplier.numberOfTransaction;
    transactionSpan.id = 'edit-supplier-transactions';
    transactionSpan.classList.add('form-control');
    transactionDiv.appendChild(transactionSpan);
    form.appendChild(transactionDiv);

    // Amount
    let amountDiv = div.cloneNode(false);
    let amountLabel = label.cloneNode(false);
    amountLabel.classList.add('form-label');
    amountLabel.classList.add('me-2');
    amountLabel.classList.add('mt-2');
    amountLabel.innerText = 'Total Amount:';
    amountLabel.for = 'edit-supplier-amount';
    amountDiv.appendChild(amountLabel);

    let amountSpan = span.cloneNode(false);
    amountSpan.innerText = supplier.totalAmount;
    amountSpan.id = 'edit-supplier-amount';
    amountSpan.classList.add('form-control');
    amountDiv.appendChild(amountSpan);
    form.appendChild(amountDiv);

    // Buttons
    let btnDiv = div.cloneNode(false);
    btnDiv.classList.add('d-inline-flex');
    btnDiv.classList.add('justify-content-center');
    btnDiv.classList.add('align-items-center');

    let editBtn = btn.cloneNode(false);
    editBtn.type = 'submit';
    editBtn.classList.add('btn');
    editBtn.classList.add('btn-success');
    editBtn.classList.add('edit-btn');
    editBtn.classList.add('me-2');

    editBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <path d="M21.2799 6.40005L11.7399 15.94C10.7899 16.89 7.96987 17.33 7.33987 16.7C6.70987 16.07 7.13987 13.25 8.08987 12.3L17.6399 2.75002C17.8754 2.49308 18.1605 2.28654 18.4781 2.14284C18.7956 1.99914 19.139 1.92124 19.4875 1.9139C19.8359 1.90657 20.1823 1.96991 20.5056 2.10012C20.8289 2.23033 21.1225 2.42473 21.3686 2.67153C21.6147 2.91833 21.8083 3.21243 21.9376 3.53609C22.0669 3.85976 22.1294 4.20626 22.1211 4.55471C22.1128 4.90316 22.0339 5.24635 21.8894 5.5635C21.7448 5.88065 21.5375 6.16524 21.2799 6.40005V6.40005Z" stroke="orange" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    <path d="M11 4H6C4.93913 4 3.92178 4.42142 3.17163 5.17157C2.42149 5.92172 2 6.93913 2 8V18C2 19.0609 2.42149 20.0783 3.17163 20.8284C3.92178 21.5786 4.93913 22 6 22H17C19.21 22 20 20.2 20 18V13" stroke="#ffffff" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"/>
    </svg>`;

    btnDiv.appendChild(editBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.type = 'button';
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('cn-btn');

    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    btnDiv.appendChild(cancelBtn);
    form.appendChild(btnDiv);

    editDiv.appendChild(form);
    modalDiv.appendChild(editDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}
//#endregion

//#region delete display

function openDeleteBusinessTransaction(id) {
    if (!_transactionExists(id)) {
        alert('This transaction cannot be found');
        return;
    }

    let transaction = _transactions.find(x => x.id === id);

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let dl = document.createElement('dl');
    dl.classList.add('row');
    let dt = document.createElement('dt');
    let dd = document.createElement('dd');
    let btn = document.createElement('button');

    let deleteDiv = document.createElement('div');
    deleteDiv.id = 'delete-div';

    let nameDt = dt.cloneNode(false);
    nameDt.classList.add('col-sm-2');
    nameDt.innerText = 'Name:';
    let nameDd = dd.cloneNode(false);
    nameDd.classList.add('col-sm-10');
    nameDd.innerText = transaction.name;
    dl.appendChild(nameDt);
    dl.appendChild(nameDd);

    let dateDt = dt.cloneNode(false);
    dateDt.classList.add('col-sm-2');
    dateDt.innerText = 'Date:';
    let dateDd = dd.cloneNode(false);
    dateDd.classList.add('col-sm-10');
    dateDd.innerText = transaction.date.substring(0, 10);
    dl.appendChild(dateDt);
    dl.appendChild(dateDd);

    let catDt = dt.cloneNode(false);
    catDt.classList.add('col-sm-2');
    catDt.innerText = 'Category:';
    let catDd = dd.cloneNode(false);
    catDd.classList.add('col-sm-10');
    catDd.innerText = transaction.category.name;
    dl.appendChild(catDt);
    dl.appendChild(catDd);

    let supDt = dt.cloneNode(false);
    supDt.classList.add('col-sm-2');
    supDt.innerText = 'Category:';
    let supDd = dd.cloneNode(false);
    supDd.classList.add('col-sm-10');
    supDd.innerText = transaction.supplier.name;
    dl.appendChild(supDt);
    dl.appendChild(supDd);

    let amountDt = dt.cloneNode(false);
    amountDt.classList.add('col-sm-2');
    amountDt.innerText = 'Amount:';
    let amountDd = dd.cloneNode(false);
    amountDd.classList.add('col-sm-10');
    amountDd.innerText = new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(transaction.amount);
    dl.appendChild(amountDt);
    dl.appendChild(amountDd);

    let btnDt = dt.cloneNode(false);
    btnDt.classList.add('col-sm-2');
    let btnDd = dd.cloneNode(false);
    btnDd.classList.add('col-sm-10');

    let delBtn = btn.cloneNode(false);
    delBtn.classList.add('btn');
    delBtn.classList.add('btn-danger');
    delBtn.classList.add('me-2');
    delBtn.classList.add('mt-2');

    delBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>    
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>    
    <g id="SVGRepo_iconCarrier">
    <path d="M20 14V7C20 5.34315 18.6569 4 17 4H12M20 14L13.5 20M20 14H15.5C14.3954 14 13.5 14.8954 13.5 16V20M13.5 20H7C5.34315 20 4 18.6569 4 17V12" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> <path d="M4 4L6.5 6.5M9 9L6.5 6.5M6.5 6.5L9 4M6.5 6.5L4 9" stroke="orange" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> </g>
    </svg>`;

    delBtn.setAttribute('onclick', `deleteBusinessTransaction(${transaction.id})`);
    btnDd.appendChild(delBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('mt-2');
    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    btnDd.appendChild(cancelBtn);

    dl.appendChild(btnDt);
    dl.appendChild(btnDd);
    deleteDiv.appendChild(dl);
    modalDiv.appendChild(deleteDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openDeleteBusinessCategory(id) {
    if (!_categoryExists(id)) {
        alert('This category cannot be found');
        return;
    }

    let category = _categories.find(x => x.id === id);

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let dl = document.createElement('dl');
    dl.classList.add('row');
    let dt = document.createElement('dt');
    let dd = document.createElement('dd');
    let btn = document.createElement('button');

    let deleteDiv = document.createElement('div');
    deleteDiv.id = 'delete-div';

    let nameDt = dt.cloneNode(false);
    nameDt.classList.add('col-sm-6');
    nameDt.innerText = 'Name:';
    let nameDd = dd.cloneNode(false);
    nameDd.classList.add('col-sm-6');
    nameDd.innerText = category.name;
    dl.appendChild(nameDt);
    dl.appendChild(nameDd);

    let transactionDt = dt.cloneNode(false);
    transactionDt.classList.add('col-sm-6');
    transactionDt.innerText = 'Number of Transaction:';
    let transactionDd = dd.cloneNode(false);
    transactionDd.classList.add('col-sm-6');
    transactionDd.innerText = category.numberOfTransaction;
    dl.appendChild(transactionDt);
    dl.appendChild(transactionDd);

    let amountDt = dt.cloneNode(false);
    amountDt.classList.add('col-sm-6');
    amountDt.innerText = 'Total Amout:';
    let amountDd = dd.cloneNode(false);
    amountDd.classList.add('col-sm-6');
    amountDd.innerText = new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(category.totalAmount);
    dl.appendChild(amountDt);
    dl.appendChild(amountDd);

    let btnDt = dt.cloneNode(false);
    btnDt.classList.add('col-sm-6');
    let btnDd = dd.cloneNode(false);
    btnDd.classList.add('col-sm-6');

    let delBtn = btn.cloneNode(false);
    delBtn.classList.add('btn');
    delBtn.classList.add('btn-danger');
    delBtn.classList.add('me-2');
    delBtn.classList.add('mt-2');

    delBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>    
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>    
    <g id="SVGRepo_iconCarrier">
    <path d="M20 14V7C20 5.34315 18.6569 4 17 4H12M20 14L13.5 20M20 14H15.5C14.3954 14 13.5 14.8954 13.5 16V20M13.5 20H7C5.34315 20 4 18.6569 4 17V12" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> <path d="M4 4L6.5 6.5M9 9L6.5 6.5M6.5 6.5L9 4M6.5 6.5L4 9" stroke="orange" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> </g>
    </svg>`;

    delBtn.setAttribute('onclick', `deleteBusinessCategory(${category.id})`);
    btnDd.appendChild(delBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('mt-2');
    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    btnDd.appendChild(cancelBtn);

    dl.appendChild(btnDt);
    dl.appendChild(btnDd);
    deleteDiv.appendChild(dl);
    modalDiv.appendChild(deleteDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}

function openDeleteBusinessSupplier(id) {
    if (!_supplierExists(id)) {
        alert('This supplier cannot be found');
        return;
    }

    let supplier = _suppliers.find(x => x.id === id);

    let modalDiv = document.getElementById('modal-div');
    modalDiv.style.display = 'inline-block';

    let dl = document.createElement('dl');
    dl.classList.add('row');
    let dt = document.createElement('dt');
    let dd = document.createElement('dd');
    let btn = document.createElement('button');

    let deleteDiv = document.createElement('div');
    deleteDiv.id = 'delete-div';

    let nameDt = dt.cloneNode(false);
    nameDt.classList.add('col-sm-6');
    nameDt.innerText = 'Name:';
    let nameDd = dd.cloneNode(false);
    nameDd.classList.add('col-sm-6');
    nameDd.innerText = supplier.name;
    dl.appendChild(nameDt);
    dl.appendChild(nameDd);

    let transactionDt = dt.cloneNode(false);
    transactionDt.classList.add('col-sm-6');
    transactionDt.innerText = 'Number of Transaction:';
    let transactionDd = dd.cloneNode(false);
    transactionDd.classList.add('col-sm-6');
    transactionDd.innerText = supplier.numberOfTransaction;
    dl.appendChild(transactionDt);
    dl.appendChild(transactionDd);

    let amountDt = dt.cloneNode(false);
    amountDt.classList.add('col-sm-6');
    amountDt.innerText = 'Total Amout:';
    let amountDd = dd.cloneNode(false);
    amountDd.classList.add('col-sm-6');
    amountDd.innerText = new Intl.NumberFormat('fr-CH', { style: 'currency', currency: 'chf' }).format(supplier.totalAmount);
    dl.appendChild(amountDt);
    dl.appendChild(amountDd);

    let btnDt = dt.cloneNode(false);
    btnDt.classList.add('col-sm-6');
    let btnDd = dd.cloneNode(false);
    btnDd.classList.add('col-sm-6');

    let delBtn = btn.cloneNode(false);
    delBtn.classList.add('btn');
    delBtn.classList.add('btn-danger');
    delBtn.classList.add('me-2');
    delBtn.classList.add('mt-2');

    delBtn.innerHTML = `<svg width="24px" height="24px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <g id="SVGRepo_bgCarrier" stroke-width="0"/>    
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"/>    
    <g id="SVGRepo_iconCarrier">
    <path d="M20 14V7C20 5.34315 18.6569 4 17 4H12M20 14L13.5 20M20 14H15.5C14.3954 14 13.5 14.8954 13.5 16V20M13.5 20H7C5.34315 20 4 18.6569 4 17V12" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> <path d="M4 4L6.5 6.5M9 9L6.5 6.5M6.5 6.5L9 4M6.5 6.5L4 9" stroke="orange" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/> </g>
    </svg>`;

    delBtn.setAttribute('onclick', `deleteBusinessSupplier(${supplier.id})`);
    btnDd.appendChild(delBtn);

    let cancelBtn = btn.cloneNode(false);
    cancelBtn.classList.add('btn');
    cancelBtn.classList.add('btn-warning');
    cancelBtn.classList.add('mt-2');
    cancelBtn.setAttribute('onclick', `closeModalDiv()`);
    cancelBtn.innerHTML = `<svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 128.00 128.00" enable-background="new 0 0 128 128" xml:space="preserve" fill="#000000">
    <g id="SVGRepo_bgCarrier" stroke-width="0"></g>
    <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round"></g>
    <g id="SVGRepo_iconCarrier"> <g> <g> 
    <path fill="#ffffff" d="M64,0C28.656,0,0,28.656,0,64s28.656,64,64,64s64-28.656,64-64S99.344,0,64,0z M64,120 C33.125,120,8,94.875,8,64S33.125,8,64,8s56,25.125,56,56S94.875,120,64,120z"></path> </g> </g> <g> <g> <path fill="#ff8040" d="M75.313,64l16.969-16.969c3.125-3.125,3.125-8.195,0-11.313c-3.117-3.125-8.188-3.125-11.313,0L64,52.688 L47.031,35.719c-3.125-3.125-8.195-3.125-11.313,0c-3.125,3.117-3.125,8.188,0,11.313L52.688,64L35.719,80.969 c-3.125,3.125-3.125,8.195,0,11.313c3.117,3.125,8.188,3.125,11.313,0L64,75.313l16.969,16.969c3.125,3.125,8.195,3.125,11.313,0 c3.125-3.117,3.125-8.188,0-11.313L75.313,64z"></path> </g> </g> </g></svg>`;

    btnDd.appendChild(cancelBtn);

    dl.appendChild(btnDt);
    dl.appendChild(btnDd);
    deleteDiv.appendChild(dl);
    modalDiv.appendChild(deleteDiv);

    window.onclick = function (event) {
        if (event.target == modalDiv) {
            closeModalDiv();
        }
    }
}
//#endregion

//#region pagination

function goToPage(page) {
    
    _currentPage = page;

    _setPagination();
    if (sessionStorage.getItem('script') === 'personal') _displayPersonalItems();
    else _displayBusinessItems();
}

function _getTransactionMaxPage() {
    _maxPage = Math.ceil(_transactions.length / 20).toFixed(0);
}

function _setPagination() {
    let ul = document.getElementById('page-ul');
    ul.innerHTML = '';

    let li = document.createElement('li');
    let a = document.createElement('a');
    _pageElements = 0;

    let firstLi = li.cloneNode(false);
    firstLi.classList.add('page-item');
    let firstA = a.cloneNode(false);
    firstA.innerText = 'First';
    firstA.classList.add('page-link');
    firstA.classList.add('text-light');

    if (_currentPage > 1) {
        firstA.setAttribute('onclick', `goToPage(1)`);
        firstA.classList.add('bg-dark');
    } else {
        firstLi.classList.add('disabled');
        firstA.classList.add('bg-secondary');
    } firstLi.appendChild(firstA);

    ul.appendChild(firstLi);

    let prevLi = li.cloneNode(false);
    prevLi.classList.add('page-item');
    let prevA = a.cloneNode(false);
    prevA.innerText = 'Prev';
    prevA.classList.add('page-link');
    prevA.classList.add('text-light');

    if (_currentPage > 1) {
        prevA.setAttribute('onclick', `goToPage(${_currentPage - 1})`);
        prevA.classList.add('bg-dark');
    } else {
        prevLi.classList.add('disabled');
        prevA.classList.add('bg-secondary');
    }
    prevLi.appendChild(prevA);
    ul.appendChild(prevLi);

    let backPageElems = 0;
    if (_currentPage > 5) backPageElems += 5;
    else backPageElems += _currentPage - 1;

    for (let i = _currentPage - backPageElems; i < _currentPage; i++) {
        let pageLi = li.cloneNode(false);
        pageLi.classList.add('page-item');
        let pageA = a.cloneNode(false);
        pageA.innerText = i;
        pageA.classList.add('page-link');
        pageA.classList.add('text-light');
        pageA.classList.add('bg-dark');
        pageA.setAttribute('onclick', `goToPage(${i})`);
        pageLi.appendChild(pageA);
        ul.appendChild(pageLi);
    }

    let currentLi = li.cloneNode(false);
    currentLi.classList.add('page-item');
    currentLi.classList.add('disabled');
    let currentA = a.cloneNode(false);
    currentA.innerText = _currentPage;
    currentA.classList.add('page-link');
    currentLi.appendChild(currentA);
    ul.appendChild(currentLi);

    let nextPageElems = 0;
    if (_currentPage < _maxPage - 4) nextPageElems += 5;
    else nextPageElems += _maxPage - _currentPage;


    for (let i = _currentPage + 1; i < _currentPage + nextPageElems + 1; i++) {
        let pageLi = li.cloneNode(false);
        pageLi.classList.add('page-item');
        let pageA = a.cloneNode(false);
        pageA.innerText = i;
        pageA.classList.add('page-link');
        pageA.classList.add('text-light');
        pageA.classList.add('bg-dark');
        pageA.setAttribute('onclick', `goToPage(${i})`);
        pageLi.appendChild(pageA);
        ul.appendChild(pageLi);
    }

    let nextLi = li.cloneNode(false);
    nextLi.classList.add('page-item');
    let nextA = a.cloneNode(false);
    nextA.innerText = 'Next';
    nextA.classList.add('page-link');
    nextA.classList.add('text-light');

    if (_currentPage < _maxPage) {
        nextA.setAttribute('onclick', `goToPage(${_currentPage + 1})`);
        nextA.classList.add('bg-dark');
    } else {
        nextLi.classList.add('disabled');
        nextA.classList.add('bg-secondary');

    } nextLi.appendChild(nextA);
    ul.appendChild(nextLi);

    let lastLi = li.cloneNode(false);
    lastLi.classList.add('page-item');
    let lastA = a.cloneNode(false);
    lastA.innerText = 'Last';
    lastA.classList.add('page-link');
    lastA.classList.add('text-light');

    if (_currentPage < _maxPage) {
        lastA.setAttribute('onclick', `goToPage(${_maxPage})`);
        lastA.classList.add('bg-dark');
    } else {
        lastLi.classList.add('disabled');
        lastA.classList.add('bg-secondary');
    } lastLi.appendChild(lastA);
    ul.appendChild(lastLi);
}

//#endregion

//#region Search

function searchBusinessTransactions() {
    _order = 'id';
    _currentPage = 1;
    _businessTransactionSearch.name = document.getElementById('search-transaction-name').value;
    if (document.getElementById('search-date-box').checked) {
        _businessTransactionSearch.dateBox = document.getElementById('search-date-box').checked;
        _businessTransactionSearch.dateMode = document.getElementById('search-date-select').value;
        _businessTransactionSearch.date = document.getElementById('search-date-input').value;
    }
    else {
        _businessTransactionSearch.dateMode = 'more';
        _businessTransactionSearch.date = '0001-01-01';
    }

    if (document.getElementById('search-amount-box').checked) {
        _businessTransactionSearch.amountBox = document.getElementById('search-amount-box').checked;
        _businessTransactionSearch.amountMode = document.getElementById('search-amount-select').value;
        _businessTransactionSearch.amount = document.getElementById('search-amount-input').value;
    }
    else {
        _businessTransactionSearch.amountMode = 'more';
        _businessTransactionSearch.amount = 0;
    }

    _businessTransactionSearch.categoryId = document.getElementById('search-category-select').value;
    _businessTransactionSearch.supplierId = document.getElementById('search-supplier-select').value;
    _businessTransactionSearch.recurrent = document.getElementById('search-recurrent-select').value;

    getBusinessItems(_section);
}

//#endregion

//#region Global Methods

async function setSearch() {
    if (_section === 'businessTransactions') _displayBusinessTransactionSearch();
    else if (_section === 'personalTransactions') _displayPersonalTransactionSearch();
    else document.getElementById('nav-search-form').innerHTML = '';
}

function closeModalDiv() {
    let modalDiv = document.getElementById('modal-div');
    modalDiv.innerHTML = '';
    modalDiv.style.display = 'none';
}

async function setJsScript(script) {
    _currentPage = 1;
    document.getElementById('nav-search-form').innerHTML = '';
    _lastSection = '';
    _order = 'id';
    if (script === 'business') {
        document.getElementById('nav-dd-a').innerText = 'Business';

        let ul = document.getElementById('nav-ul');
        let li = document.createElement('li');
        let a = document.createElement('a');

        ul.innerHTML = '';

        let li1 = li.cloneNode(false);
        li1.classList.add('nav-item');

        let a1 = a.cloneNode(false);
        a1.classList.add('nav-link');
        a1.classList.add('active');
        a1.classList.add('text-light');
        a1.setAttribute('onclick', `getBusinessItems('businessTransactions')`);
        a1.innerText = 'Transactions';

        li1.appendChild(a1);
        ul.appendChild(li1);

        let li2 = li.cloneNode(false);
        li2.classList.add('nav-item');

        let a2 = a.cloneNode(false);
        a2.classList.add('nav-link');
        a2.classList.add('active');
        a2.classList.add('text-light');
        a2.setAttribute('onclick', `getBusinessItems('businessCategories')`);
        a2.innerText = 'Categories';

        li2.appendChild(a2);
        ul.appendChild(li2);

        let li3 = li.cloneNode(false);
        li3.classList.add('nav-item');

        let a3 = a.cloneNode(false);
        a3.classList.add('nav-link');
        a3.classList.add('active');
        a3.classList.add('text-light');
        a3.setAttribute('onclick', `getBusinessItems('businessSuppliers')`);
        a3.innerText = 'Suppliers';

        li3.appendChild(a3);
        ul.appendChild(li3);

        sessionStorage.setItem('lastUrl', '');
        sessionStorage.setItem('script', 'business');
        sessionStorage.setItem('section', 'businessTransactions');

        getBusinessItems('businessTransactions');
    }
    else {
        let autoAddDiv = document.getElementById('auto-add-div');
        autoAddDiv.style.display = 'none';

        let autoAddBtn = document.getElementById('auto-add-btn');
        autoAddBtn.style.display = 'none';
        autoAddBtn.disabled = true;

        let autoStopBtn = document.getElementById('auto-stop-btn');
        autoStopBtn.style.display = 'none';
        autoStopBtn.disabled = true;

        let navDiv = document.getElementById('nav-dd-a').innerText = 'Personal';

        let ul = document.getElementById('nav-ul');
        let li = document.createElement('li');
        let a = document.createElement('a');

        ul.innerHTML = '';

        let li1 = li.cloneNode(false);
        li1.classList.add('nav-item');

        let a1 = a.cloneNode(false);
        a1.classList.add('nav-link');
        a1.classList.add('active');
        a1.classList.add('text-light');
        a1.setAttribute('onclick', `getPersonalItems('personalTransactions')`);
        a1.innerText = 'Transactions';

        li1.appendChild(a1);
        ul.appendChild(li1);

        let li2 = li.cloneNode(false);
        li2.classList.add('nav-item');

        let a2 = a.cloneNode(false);
        a2.classList.add('nav-link');
        a2.classList.add('active');
        a2.classList.add('text-light');
        a2.setAttribute('onclick', `getPersonalItems('personalCategories')`);
        a2.innerText = 'Categories';

        li2.appendChild(a2);
        ul.appendChild(li2);

        sessionStorage.setItem('lastUrl', '');
        sessionStorage.setItem('script', 'personal');
        sessionStorage.setItem('section', 'personalTransactions');

        getPersonalItems('personalTransactions');
    }
}

function _setUrl() {
    if (sessionStorage.getItem('script') === 'personal') {
        let url = `${uri}/PersonalTransaction/?`;
        if (_personalTransactionSearch.dateBox) url += `dateBox=true&dateMode=${_personalTransactionSearch.dateMode}&date=${_personalTransactionSearch.date}&`;
        if (_personalTransactionSearch.amountBox) url += `amountBox=true&amountMode=${_personalTransactionSearch.amountMode}&amount=${_personalTransactionSearch.amount}&`;
        url += `categoryId=${_personalTransactionSearch.categoryId}&`;
        if (_personalTransactionSearch.name != '' && _personalTransactionSearch.name != null) url += `name=${_personalTransactionSearch.name}`;
        return url;
    }
    else {
        let url = `${uri}/BusinessTransaction/?`;
        if (_businessTransactionSearch.dateBox) url += `dateBox=true&dateMode=${_businessTransactionSearch.dateMode}&date=${_businessTransactionSearch.date}&`;
        if (_businessTransactionSearch.amountBox) url += `amountBox=true&amountMode=${_businessTransactionSearch.amountMode}&amount=${_businessTransactionSearch.amount}&`;
        url += `supplierId=${_businessTransactionSearch.supplierId}&categoryId=${_businessTransactionSearch.categoryId}&recurrent=${_businessTransactionSearch.recurrent}&`;
        if (_businessTransactionSearch.name != '' && _businessTransactionSearch.name != null) url += `name=${_businessTransactionSearch.name}`;

        return url;
    }
}

async function getItems(script) {
    if (script === 'personal') {

        _section = "personalTransactions";
        _transactions;
        _maxPage = 1;
        _currentPage = 1;
        _categories;
        _suppliers;
        _currentUrl = "";
        _transactionSearch = {
            name: '',
            dateBox: false,
            dateMode: 'more',
            date: new Date(Date.now()).toISOString().slice(0, 10),
            amountBox: false,
            amountMode: 'more',
            amount: 0,
            categoryId: 0,
        };
        setJsScript(script);
    }
    else {

        _section = "businessTransactions";
        _transactions;
        _maxPage = 1;
        _currentPage = 1;
        _categories;
        _suppliers;
        _currentUrl = "";
        _businessTransactionSearch = {
            name: '',
            dateBox: false,
            dateMode: 'more',
            date: new Date(Date.now()).toISOString().slice(0, 10),
            amountBox: false,
            amountMode: 'more',
            amount: 0,
            categoryId: 0,
            supplierId: 0,
        };
        setJsScript(script);
    };
}

function _transactionExists(id) {
    return _transactions.find(x => x.id === id) != null;
}

function _categoryExists(id) {
    return _categories.find(x => x.id === id) != null;
}

function _supplierExists(id) {
    return _suppliers.find(x => x.id === id) != null;
}

function orderBy(order) {
    switch (order) {
        case "id":
            _transactions = order != _order ? _transactions.sort((x, y) => x.id > y.id) : _transactions.toReversed();
            break;
        case "name":
            _transactions = order != _order ? _transactions.sort((x,y) => x.name > y.name) : _transactions.reverse();
            break;
        case "date":
            _transactions = order != _order ? _transactions.sort((x, y) => x.date > y.date) : _transactions.reverse();
            break;
        case "category":
            _transactions = order != _order ? _transactions.sort((x, y) => x.category.name > y.category.name) : _transactions.reverse();
            break;
        case "amount":
            _transactions = order != _order ? _transactions.sort((x, y) => x.amount > y.amount) : _transactions.reverse();
            break;
        case "supplier":
            _transactions = order != _order ? _transactions.sort((x, y) => x.supplier.name > y.supplier.name) : _transactions.reverse();
            break;
    }
    _order = order;
    if (_section.includes('business')) _displayBusinessItems();
    else _displayPersonalItems();
}

function _highlightOrder() {
    switch (_order) {
        case "id":
            document.getElementById('th-a-id').classList.add('text-warning-emphasis');
            break;
        case "name":
            document.getElementById('th-a-name').classList.add('text-warning-emphasis');
            break;
        case "date":
            document.getElementById('th-a-date').classList.add('text-warning-emphasis');
            break;
        case "category":
            document.getElementById('th-a-cat').classList.add('text-warning-emphasis');
            break;
        case "supplier":
            document.getElementById('th-a-supp').classList.add('text-warning-emphasis');
            break;
        case "amount":
            document.getElementById('th-a-amount').classList.add('text-warning-emphasis');
            break;
    }
}

//#endregion