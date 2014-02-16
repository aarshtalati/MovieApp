/// <reference path="jquery-2.1.0.min.js" />
var bgColors = ['#2E8DEF', '#00A0B1', '#536eb2', '#A700AE', '#643EBF', '#BF1E4B', '#DC572E', '#00A600', '#0A5BC4', '#306772', '#CEA539', '#E773BD', '#2C618F', '#694526'];

/* File Created: February 15, 2014 */
$(function () {
	//Placeholder : feature detection
	if (!Modernizr.input.placeholder) {
		$("input").each(function () {
			if ($(this).val() === "" && $(this).attr("placeholder") !== "") {
				$(this).val($(this).attr("placeholder"));
				$(this).focus(function () {
					if ($(this).val() === $(this).attr("placeholder")) {
						$(this).val("");
					}
				});
				$(this).blur(function () {
					if ($(this).val() === "") {
						$(this).val($(this).attr("placeholder"));
					}
				});
			}
		});
	}

	$('ul.filterTarget > li').each(function (index) {
		$(this).css('background-color', bgColors[Math.floor(Math.random() * bgColors.length)]);
	});
	$('#txtFilter').keyup(function () {
		var searchString = this.value;
		
		if ($('.filterTarget').prop('tagName').toLowerCase() === 'ul') {
			listSearch(searchString, this);
		} else if ($('.filterTarget').prop('tagName').toLowerCase() === 'table') {
			tableSearch(searchString, this);
		}
	});
});

function listSearch(searchString, element) {
	if (searchString === "") {
		$('ul.filterTarget > li').show();
		return;
	} else {
		filter(element);
	}
}
function tableSearch(searchString, element) {
	if (searchString === "") {
		$('table.filterTarget tr').show();
		return;
	} else {
		searchString = searchString.toLowerCase();
		var rows = $('table.filterTarget tr');
		
		$('table.filterTarget tr').each(function (index) {
			if ($(this).html().toLowerCase().indexOf(searchString) >= 0)
				$(this).show();
			else
				$(this).hide();
		});
	}
}
function filter(element) {
	var value = $(element).val().toLowerCase();
	var $li = $("ul.filterTarget  > li");

	$li.hide();
	$li.filter(function () {
		return $(this).text().toLowerCase().indexOf(value) > -1;
	}).show();
}