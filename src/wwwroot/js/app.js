// slider functions
window.sliderFunctions = {
    createSlider: function (id, dotnetHelper) {
        var slider = new Slider(id, {
            formatter: function(value) {
                return value;
            }
        });

        slider.on('change', function () {
            return dotnetHelper.invokeMethodAsync('UpdateDamageTrackValue', slider.getValue())
        });
    }
}

// bootstrap-table functions
window.bootstrapTableFunctions = {
    createTable: function(id) {
        $(id).bootstrapTable();
    },
    createTreeGrid: function(id) {
        var $table = $(id)

        $table.bootstrapTable({
            treeShowField: 'name',
            parentIdField: 'pid',
            id: 'id',
            pagination: false,
            onPostBody: function () {
                $table.treegrid({
                    treeColumn: 0,
                    initialState: 'collapsed',
                    onChange: function () {
                        $table.bootstrapTable('resetView')
                    }
                })
            }
        });
    },
    filterTable: function(id, filter) {
        $(id).bootstrapTable('filterBy', filter);
    },
    refreshEffectTable: function(id, json) {
        $(id).bootstrapTable('destroy').bootstrapTable({data: JSON.parse(json)});
    },
    skillButtons: function() {
        return {
            btnFilterCombatActive: {
                text: 'Combat',
                icon: 'oi oi-bullhorn',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Combat Active'
                    })
                }
            },
            btnFilterMagicalActive: {
                text: 'Magical',
                icon: 'oi oi-star',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Magical Active'
                    })
                }
            },
            btnFilterPhysicalActive: {
                text: 'Physical',
                icon: 'oi oi-pulse',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Physical Active'
                    })
                }
            },
            btnFilterSocialActive: {
                text: 'Social',
                icon: 'oi oi-yen',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Social Active'
                    })
                }
            },
            btnFilterTechnicalActive: {
                text: 'Technical',
                icon: 'oi oi-power-standby',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Technical Active'
                    })
                }
            },
            btnFilterVehicleActive: {
                text: 'Vehicle',
                icon: 'oi oi-map-marker',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", {
                        category: 'Vehicle Active'
                    })
                }
            },
            btnFilterClear: {
                text: 'Clear',
                icon: 'oi oi-circle-x',
                event: function() {
                    window.bootstrapTableFunctions.filterTable("#skill-table", "")
                }
            }
        }
    },
    importantDetailFormatter: function(index, row) {
        var html = [];

        $.each(row, function (key, value) {
            if (key === 'detail') {
                html.push('<p>' + value + '</p>')
            }
        });

        return html.join('');
    },
    effectDeactivateFormatter: function(value, row, index) {
        return [
            '<a class="remove" href="javascript:void(0)" title="Remove">',
            '<i class="oi oi-trash"></i>',
            '</a>'
        ].join('')
    },
    'click .remove': function(e, value, row, index) {
        $(e.currentTarget).closest('table').bootstrapTable('remove', {
            field: 'id',
            values: [row.id]
        });

        DotNet.invokeMethodAsync('src', 'RemoveEffectFromJs', row.name);
    },
    powerAddCurrentEffect: function(table, button) {
        var rowIndex = $(button).parent().parent().attr("data-index");
        
        var rawData = $("#" + table).bootstrapTable('getData')[rowIndex];
        
        var data = {};
        data.type = "ATTRIBUTE";
        data.value_to_affect = rawData.affects;
        data.name = rawData.name;
        data.rating = rawData.rating;

        DotNet.invokeMethodAsync('src', 'AddEffectFromJs', JSON.stringify(data));
    },
    updateAttributeRow: function(index, row) {
        $('#attribute-table').bootstrapTable('updateRow', {index: index, row: row});
    },
}