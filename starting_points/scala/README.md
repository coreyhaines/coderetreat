## Scala Starting Point

Project files for the three most popular Scala IDEs (Eclipse,
NetBeans, and IntelliJ) are included with this starting point.
Instructions for each IDE are below.

In addition to the IDE project files, the starting point also includes
a [SBT](https://github.com/harrah/xsbt/wiki) build file and a 
[Maven](http://maven.apache.org/) POM. If you prefer, feel free to use
the build systems directly (or to create your own IDE configuration).

This starting point includes the following libraries:

* [Scala 2.9.0.1](http://www.scala-lang.org/)
* [ScalaTest 1.6.1](http://scalatest.org/)
* [Specs 1.4.4](http://code.google.com/p/specs/)
* [JUnit 4.8.2](http://www.junit.org/) (for running tests in some of the IDEs)

### Java
Of course, to develop in Scala, you need Java.

Install [Java SE SDK 6](http://www.oracle.com/technetwork/java/javase/downloads/index.html). 
At the time this file was written, the latest version for download was
[Java SE 6 Update 29](http://www.oracle.com/technetwork/java/javase/downloads/jdk-6u29-download-513648.html).

### Eclipse
#### Install Pre-requisites
1. Install [Eclipse IDE for Java Developers](http://www.eclipse.org/downloads/).

   **Note:** the starting point was tested on the Indigo Eclipse Release.

2. Add the Scala IDE Update Site:
    1. Open _Help -> Install New Software.._
    2. Click the _Add.._ button
    3. Enter **Scala IDE** in the _Name_ textbox.
    4. Enter **http://download.scala-ide.org/releases/2.0.0-beta** in the
       Location text box.
    5. Click _Ok_
3. Check the box next to the _Scala IDE for Eclipse_ plugin in the list of
   plugins.
4. Click _Next_
5. Click _Next_
6. Accept the license
7. Click _Next_
8. If prompted about installing unsigned content, click _Continue_
9. When prompted, restart Eclipse

_**Tip:**_ More detailed installation instructions for the Eclipse
Scala plugin can be found on [the Scala IDE website](http://www.scala-ide.org/).


#### Import Starting Point
1. Launch Eclipse
2. Select _File -> Import.._
3. Select _General -> Existing Projects into Workspace_
4. Browse to where you have the starting points checked-out.
5. Select the **scala** folder
6. Make sure **conways-game-of-life-scala** is checked in the Projects list.
7. Click _Finish_
8. Enjoy!


### NetBeans
#### Install Pre-requisites
1. Install [NetBeans](http://netbeans.org/downloads/).
   You only need the edition which contains just Java SE. You don't
   need any of the other tools for the Coderetreat.

   **Note:** the starting point was tested on version 7.0.1.

2. Install the Scala Plugins (download from: XXX). Installation
   instructions can be found at XXX.

_**Tip:**_ More detailed installation instructions for the NetBeans
Scala plugin can be found on [the NetBeans Scala wiki page](http://wiki.netbeans.org/Scala).

#### Import Starting Point
1. Launch NetBeans
2. Select _File -> Open Project.._
3. Browse to where you have the starting points checked-out.
4. Select the **scala** folder.
5. Click _Open Project_
6. Enjoy!

### IntelliJ IDEA
#### Install Pre-requisites
1. Install [IntelliJ IDEA Community Edition](http://www.jetbrains.com/idea/download/).

   **Note:** the starting point was tested on version 10.5.

2. Launch IntelliJ IDEA and open the Plugin Manager. Ether:
    * Click the _Open Plugin Manager_ link on the Welcome Page
      or:
    * Open the IDE Settings (_File -> Settings_) and select _Plugins_
      under _IDE Settings_

3. Switch to the _Available_ tab
4. Type **Scala** in the search textbox
5. Right-click on Scala plugin, and select _Download and Install_
    - Optionally install SBT plugin

_**Tip:**_  More detailed installation instructions for the Scala
Plugin can be found at
[Getting Started with IntelliJ IDEA Scala Plugin](http://confluence.jetbrains.net/display/SCA/Getting+Started+with+IntelliJ+IDEA+Scala+Plugin).

#### Import Starting Point
1. Launch IntelliJ IDEA
2. Select _File -> Open Project..._
3. Browse and select the **scala** folder
4. Click _Ok_
5. Enjoy!
