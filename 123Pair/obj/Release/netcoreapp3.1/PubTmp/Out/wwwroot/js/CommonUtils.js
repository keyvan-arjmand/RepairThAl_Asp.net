function formatNumber(value, zeroValue = '0', decimals = 3) {

    if (isNumeric(value)) {
        if (Number.isInteger(value)) {
            if (value > 0) {
                return numeral(value).format('0,0');
            }
            else if (value < 0) {
                return '(' + numeral(Math.abs(value)).format('0,0') + ')';
            }
            else {
                return zeroValue;
            }
        } else {
            if (value > 0) {
                return numeral(value).format('0,0' + (decimals > 0 ? '.' + ''.padEnd(decimals, '0') : ''));
            }
            else if (value < 0) {
                return '(' + numeral(Math.abs(value)).format('0,0' + (decimals > 0 ? '.' + ''.padEnd(decimals, '0') : '')) + ')';
            }
            else {
                return zeroValue;
            }
        }

    }
    return value;
}

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function formatDate(str) {
    if (!str) {
        return '';
    }

    if (str.length != 8) {
        return str;
    }

    return insert(insert(str, '/', 4), '/', 7);
}

function formatTime(str) {
    if (!str) {
        return '';
    }

    if (str.length != 4) {
        return str;
    }

    return insert(str, ':', 2);
}

function unformatDate(str) {
    if (!str) {
        return '';
    }

    if (str.length != 10) {
        return str;
    }

    return str.replaceAll('/', '');
}

function insert(str, value, atPosition) {
    return [str.slice(0, atPosition), value, str.slice(atPosition)].join('');
}

if (!String.format) {
    String.format = function (format) {
        var args = Array.prototype.slice.call(arguments, 1);
        return format.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined'
                ? args[number]
                : match
                ;
        });
    };
}
