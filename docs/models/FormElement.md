# OneBlink .Net SDK | FormElement Model

## `FormElment`

### Constructor

Only a default constructor is provided, instead it is recommended to create a FormElement using the static functions

### Properties

| Property                                 | Required | Type                                | Description                                                                                                                                                                                                                                                                                                               | Default Value |
| ---------------------------------------- | -------- | ----------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------- |
| `id`                                     | Yes      | `Guid`                              |                                                                                                                                                                                                                                                                                                                           |               |
| `name`                                   | Yes      | `string`                            |                                                                                                                                                                                                                                                                                                                           |               |
| `label`                                  | Yes      | `string`                            |                                                                                                                                                                                                                                                                                                                           |               |
| `conditionallyShow`                      | No       | `Boolean`                           | Whether the form is always of conditionally shown                                                                                                                                                                                                                                                                         | false         |
| `requiresAllConditionallyShowPredicates` | No       | `Boolean`                           | Whether all predicates must be true to show element                                                                                                                                                                                                                                                                       | false         |
| `type`                                   | Yes      | `string`                            | "text", "email", "textarea", "number", "select","checkboxes", "radio", "draw", "camera", "date", "time", "datetime", "heading", "location", "repeatableSet", "page", "html", "barcodeScanner", "captcha", "image", "file", "files", "calculation", "telephone", "autocomplete", "form", "infoPage", "geoscapeAddress", "summary","compliance", "pointAddress" |               |
| `required`                               | Yes      | `Boolean`                           | Whether the user us required to provided a value for this element                                                                                                                                                                                                                                                         | false         |
| `readOnly`                               | No       | `Boolean`                           | Whether the user can modify the elements value                                                                                                                                                                                                                                                                            | false         |
| `conditionallyShowPredicates`            | No       | `List<ConditionallyShowPredicate>`  | List of elements to be used as conditions                                                                                                                                                                                                                                                                                 | null          |
| `defaultValue`                           | No       | `dynamic`                           | The default value for this element                                                                                                                                                                                                                                                                                        | null          |
| `buttons`                                | No       | `Boolean`                           | Determines if this element is shown as buttons (applies to Radio buttons and checkboxes)                                                                                                                                                                                                                                  | false         |
| `multi`                                  | No       | `Boolean`                           | Whether the element is a single or mutliple slection (applies to select elements)                                                                                                                                                                                                                                         | false         |
| `isSlider`                               | No       | `Boolean`                           | Whether this element is shown as a slider (applies to number elements)                                                                                                                                                                                                                                                    | false         |
| `sliderIncrement`                        | No       | `long`                              | The size of the increments to be applied when slider is moved (applies to number elements using isSlider)                                                                                                                                                                                                                 |               |
| `minNumber`                              | No       | `long`                              | The minimum number that can entered by the user (applies to number element)                                                                                                                                                                                                                                               |               |
| `maxNumber`                              | No       | `long`                              | The maxium number that can entered by the user (applies to number element)                                                                                                                                                                                                                                                |               |
| `headingType`                            | No       | `long`                              | The size of the heading from 1 to 5 (applies to heading elements)                                                                                                                                                                                                                                                         |               |
| `fromDate`                               | No       | `DateTime`                          | The minimum date that can be entered by the user (applies to date and datetime elements)                                                                                                                                                                                                                                  |               |
| `toDate`                                 | No       | `DateTime`                          | The maximum date that can be entered by the user (applies to date and datetime elements)                                                                                                                                                                                                                                  |               |
| `optionsType`                            | No       | `string`                            | The type of the options supplied, valid values are "CUSTOM", "DYNAMIC", "SEARCH" (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                             |               |
| `dynamicOptionSetId`                     | No       | `long`                              | The id of the dynamic options set to be used with this element (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                                               |               |
| `options`                                | No       | `List<FormElementOption>`           | List of form element options (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                                                                                 |               |
| `attributesMapping`                      | No       | `List<FormElementAttributeMapping>` | List of form element attribute mapping (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                                                                       |               |
| `conditionallyShowOptions`               | No       | `Boolean`                           | Whether to show certain options conditionally (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                                                                |               |
| `conditionallyShowOptionsElementIds`     | No       | `List<Guid>`                        | List of option element ids (applies to checkboxes, radio, compliance, select and autocomplete elements)                                                                                                                                                                                                                   |               |
| `minSetEntries`                          | No       | `long`                              | The minimum number of entries that can be entered by the user (applies to repeatable set elements)                                                                                                                                                                                                                        |               |
| `maxSetEntries`                          | No       | `long`                              | The maximum number of entries that can be entered by the user (applies to repeatable set elements)                                                                                                                                                                                                                        |               |
| `addSetEntryLabel`                       | No       | `string`                            | The label to be shown with the add set entry button (applies to repeatable set elements)                                                                                                                                                                                                                                  |               |
| `removeSetEntryLabel`                    | No       | `string`                            | The label to be shown with the remove set entry button (applies to repeatable set elements)                                                                                                                                                                                                                               |               |
| `elements`                               | No       | `List<FormElement>`                 | The elments that are part of the repeatable set (applies to repeatable set elements)                                                                                                                                                                                                                                      |               |
| `restrictBarcodeTypes`                   | No       | `Boolean`                           | Whether to restrict the barcode types that can be read (applies to barcode elements)                                                                                                                                                                                                                                      | false         |
| `restrictedBarcodeTypes`                 | No       | `List<string>`                      | List of barcode types that will be scanned for (applies to barcode elements)                                                                                                                                                                                                                                              |               |
| `calculation`                            | No       | `string`                            | Formula to be used for calculation (applies to calculation elements)                                                                                                                                                                                                                                                      |               |
| `preCalculationDisplay`                  | No       | `string`                            | Text to be display whilst the calculation does not have a result (applies to calculation elements)                                                                                                                                                                                                                        |               |
| `isDataLookup`                           | No       | `Boolean`                           | Whether this element will include a lookup button                                                                                                                                                                                                                                                                         | false         |
| `elementLookupId`                        | No       | `long`                              | The id of the lookup being applied to this element                                                                                                                                                                                                                                                                        |               |
| `formId`                                 | No       | `long`                              | The id of the form to be included (applies to form and infoPage elements)                                                                                                                                                                                                                                                 |               |
| `searchUrl`                              | No       | `string`                            | The url to be used for searching for options (applies to checkboxes, radio, compliance select and autocomplete elements)                                                                                                                                                                                                  |               |
| `restrictFileTypes`                      | No       | `Boolean`                           | Whether to restrict files types (applies to file and files elements)                                                                                                                                                                                                                                                      |               |
| `restrictedFileTypes`                    | No       | `List<string>`                      | List of file types to allow (applies to file and files elements)                                                                                                                                                                                                                                                          |               |
| `minEntries`                             | No       | `int`                               | Minimun of files allowed (applies to files elements)                                                                                                                                                                                                                                                                      |               |
| `maxEntries`                             | No       | `int`                               | Maximun of files allowed (applies to files elements)                                                                                                                                                                                                                                                                      |               |
| `elementIds`                             | No       | `List<Guid>`                        | List of element Ids to be summarised (applies to summary elements)                                                                                                                                                                                                                                                        |               |
| `placeholderValue`                       | No       | `string`                            | Placeholder text for element (applies to autocomplete, number, text, textarea, email and barcode scanner elements)                                                                                                                                                                                                        |               |
| `minLength`                              | No       | `int`                               | Minimum length of a text field (applies to text and multiline elements)                                                                                                                                                                                                                                                   |               |
| `maxLength`                              | No       | `int`                               | Maximum length of a text field (applies to text and multiline elements)                                                                                                                                                                                                                                                   |               |
| `isInteger`                              | No       | `Boolean`                           | Whether the number is required to be an integer only (no decimals) (applies to number elements)                                                                                                                                                                                                                           |               |
| `stateTerritoryFilter`                   | No       | `List<string>`                      | An array of Australian State and/or Territory abbreviations that the search should be limited to.                                                                                                                                                                                                                         |               |
| `hint`                                   | No       | `string`                            | Text to display along with the label of the element with more instructions.                                                                                                                                                                                                                                               |               |
| `addressTypeFilter`                      | No       | `List<string>`                      | An array of address types that the search should be limited to.                                                                                                                                                                                                                         |               |
| `displayAsCurrency`                      | No       | `Boolean?`                          | Configure Calculation element to display result as currency.                                                                                                                                                                                                                         |               |
| `storageType`                            | No       | `string`                            | Configure storage type of elements that contain binary data(camera, draw and files). Allowed values are "legacy", "public", "private".                                                                                                                                                                                                                         |               |


### Static Functions

#### Text Element

##### `FormElement.CreateTextElement()`

Creates a new FormElement defined as a text element, including all parameters that are relvant to summary elements only

| Parameter                              | Required | Type                               | Default Value |
| -------------------------------------- | -------- | ---------------------------------- | ------------- |
| `name`                                 | Yes      | `string`                           |               |
| `label`                                | Yes      | `string`                           |               |
| `id`                                   | No       | `Guid`                             | `new Guid()`  |
| `conditionallyShow`                    | No       | `bool`                             | `false`       |
| `requiresAllConditonallyShowPredicate` | No       | `bool`                             | `false`       |
| `conditionallyShowPredicates`          | No       | `List<ConditionallyShowPredicate>` | `null`        |
| `required`                             | No       | `bool`                             | `false`       |
| `readOnly`                             | No       | `bool`                             | `false`       |
| `defaultValue`                         | No       | `string`                           | `null`        |

##### Example

```c#
FormElement textElement = FormElement.CreateTextElement(
    "Unit_test_element",
    "Unit test element",
    Guid.NewGuid(),
    false,
    false,
    null,
    true,
    false,
    "default Value"
);
```

#### Geoscape Address Element

##### `FormElement.CreateGeoscapeAddressElement()`

Creates a new FormElement defined as a `geoscapeAddress` element, including all parameters that are relevant to Geoscape Address elements only

| Parameter                              | Required | Type                               | Default Value |
| -------------------------------------- | -------- | ---------------------------------- | ------------- |
| `name`                                 | Yes      | `string`                           |               |
| `label`                                | Yes      | `string`                           |               |
| `id`                                   | No       | `Guid`                             | `new Guid()`  |
| `conditionallyShow`                    | No       | `bool`                             | `false`       |
| `requiresAllConditonallyShowPredicate` | No       | `bool`                             | `false`       |
| `conditionallyShowPredicates`          | No       | `List<ConditionallyShowPredicate>` | `null`        |
| `stateTerritoryFilter`                 | No       | `List<string>`                     | `null`        |

##### Example

```c#
FormElement geoscapeAddressElement = FormElement.CreateGeoscapeAddressElement(
    "Geoscape_test_element",
    "Geoscape test element"
);
```

#### Summary Element

##### `FormElement.CreateSummaryElement()`

Creates a new FormElement defined as a summary element, including all parameters that are relevant to summary elements only

| Parameter                              | Required | Type                               | Default Value |
| -------------------------------------- | -------- | ---------------------------------- | ------------- |
| `name`                                 | Yes      | `string`                           |               |
| `label`                                | Yes      | `string`                           |               |
| `elementIds`                           | Yes      | `List<Guid>`                       |               |
| `id`                                   | No       | `Guid`                             | `new Guid()`  |
| `conditionallyShow`                    | No       | `bool`                             | `false`       |
| `requiresAllConditonallyShowPredicate` | No       | `bool`                             | `false`       |
| `conditionallyShowPredicates`          | No       | `List<ConditionallyShowPredicate>` | `null`        |

##### Example

```c#
FormElement summaryElement = FormElement.CreateSummaryElement(
    "Summary_test_element",
    "Summary test element",
    new List<Guid>() { textElement.id },
    Guid.NewGuid(),
    false,
    false,
    null
);
```

#### Compliance Element

##### `FormElement.CreateComplianceElement()`

Creates a new FormElement defined as a compliance element, including all parameters that are relevant to compliance elements only

| Parameter                              | Required | Type                               | Default Value |
| -------------------------------------- | -------- | ---------------------------------- | ------------- |
| `name`                                 | Yes      | `string`                           |               |
| `label`                                | Yes      | `string`                           |               |
| `options`                              | Yes      | `List<FormElementOption>`          |               |
| `id`                                   | No       | `Guid?`                            | `new Guid()`  |
| `conditionallyShow`                    | No       | `bool`                             | `false`       |
| `requiresAllConditonallyShowPredicate` | No       | `bool`                             | `false`       |
| `conditionallyShowPredicates`          | No       | `List<ConditionallyShowPredicate>` | `null`        |
| `required`                             | No       | `bool`                             | `false`       |
| `readOnly`                             | No       | `bool`                             | `false`       |
| `defaultValue`                         | No       | `string`                           | `null`        |
| `hint`                                 | No       | `string`                           | `null`        |
| `isDataLookup`                         | No       | `bool`                             | `false`       |
| `dataLookupId`                         | No       | `long?`                            | `null`        |
| `isElementLookup`                      | No       | `bool`                             | `false`       |
| `elementLookupId`                      | No       | `long?`                            | `null`        |

##### Example

```c#
FormElementOption option = new FormElementOption();
option.id = Guid.NewGuid();
option.value = "A";
option.label = "A";
FormElement complianceElement = FormElement.CreateComplianceElement(
    "Compliance_test_element",
    "Compliance_test_element",
    new List<FormElementOption>(){option}
);
```

#### Point Address Element

##### `FormElement.CreatePointAddressElement()`

Creates a new FormElement defined as a `pointAddress` element, including all parameters that are relevant to Point Address elements only

| Parameter                              | Required | Type                               | Default Value |
| -------------------------------------- | -------- | ---------------------------------- | ------------- |
| `name`                                 | Yes      | `string`                           |               |
| `label`                                | Yes      | `string`                           |               |
| `id`                                   | No       | `Guid`                             | `new Guid()`  |
| `conditionallyShow`                    | No       | `bool`                             | `false`       |
| `requiresAllConditonallyShowPredicate` | No       | `bool`                             | `false`       |
| `conditionallyShowPredicates`          | No       | `List<ConditionallyShowPredicate>` | `null`        |
| `stateTerritoryFilter`                 | No       | `List<string>`                     | `null`        |
| `addressTypeFilter`                    | No       | `List<string>`                     | `null`        |

##### Example

```c#
FormElement geoscapeAddressElement = FormElement.CreateGeoscapeAddressElement(
    "Point_test_element",
    "Point test element"
);
