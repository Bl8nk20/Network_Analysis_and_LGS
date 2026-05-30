# Netzwerkanalyse-Tool in C#

Das hier ist ein revisited Projekt, welches ich initial in meiner Ausbildung geschrieben habe.
Ziel ist es, das Projekt flexibler, moderner und sauberer neu zu schreiben.

## Voranalyse

Das Projekt habe ich initial in meinem zweiten Ausbildungsjahr geschrieben.
Das Projekt konnte aus einem fest vorgeschriebenen Netzwerk feststellen, ob dieses gelöst werden konnte oder nicht.
Dafür habe ich etwas über zwei Monate gebraucht, um mir C#, Elektro-/Netzwerktechnik anzuschauen.
Es war ein eher hardgecodeter ansatz, ohne viel Flexibilität oder Erweiterbarkeit.

## Zielsetzung

Ziel des überarbeiten ist es, wieder weg vom "Vibe-Coden" zu gehen und mir persönlich zu zeigen, dass ich noch Programmieren und solch ein Projekt von Anfang an richtig planen zu können.

## Geplante Features

* Mehrere Möglichkeiten, Netzwerkpläne einlesen zu lassen
* Dynamisches Abstrahieren des Netzwerkplans auf Softwareebene
* Errechnen, ob das Netzwerk gelöst werden kann
* Einbauen von mehr als nur Widerständen, evtl Kondensatoren, Dioden, ect.

### Design Patterns

Hier liste ich alle Design-Patterns auf, die ich verwende mit einer kleinen Begründung warum.

* MVVM
* Abstract Factory-DP
* Singleton
* Builder-DP
* Dependency Injection

### Unterprojekte / Libraries

Hier liste ich die Untergliederung der einzelnen Libraries auf, in die ich das "Hauptprojekt" unterteilt habe

* Graph
* ElectricalComponents
* DataReading
* DataWriting
* Maths

## Zukunftsmusik

Hier liste ich alle Features aus, die ich liebend gerne implementiert hätte, allerdings derzeit viel zu weit in der Zukunft liegen.

* Ansicht in einem Fenster (Webbrowser, WPF-UI, etc.)
* Vorschlagen von Widerständen, falls nicht lösbar
* Optimieren / Vereinfachen des Plans, sofern möglich
