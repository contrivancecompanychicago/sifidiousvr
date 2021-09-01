---
author: Unknown Creator
company: Microsoft Corporation
generator: "PhpSpreadsheet, https://github.com/PHPOffice/PhpSpreadsheet"
title:
- Untitled Spreadsheet
- Untitled Spreadsheet
---

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Jmol.\_\_\_JmolDate=\"\$Date: 2021-08-17 21:17:38 -0500 (Tue, 17 Aug 2021) \$\"
  Jmol.\_\_\_fullJmolProperties=\"src/org/jmol/viewer/Jmol.properties\"
   
  \# THIS IS THE TRUNK - for development and release
   
  \# NOTE \-- developement is moving to GitHub. See https://github.com/BobHanson/Jmol-SwingJS
   
  \# Developers: to add a description of changes you have made,
  \# add it on a line below the \"Jmol.\_\_\_JmolVersion=\...\" line.
  \# Don\'t use Jmol.\_\_\_ in your text, as that is the key for stripping out
  \# the information saved in the JAR version of this file.
  \# The quotes above look odd for a parameter file, but they are
  \# important for the JavaScript version of Jmol.
  \#
  \# A full Jmol/JSpecView/JSmol release requires the following:
  \#
  \# 1. Generate a new version number. This should be done as in the following examples,
  \# listed in order of appearance:
  \#
  \# previous new
  \#
  \# 14.8.10 14.8.11-beta-2016-12-20 a beta release of 14.8.11 with a timestamp for Dec 20, 2016
  \# 14.8.10 14.8.11 bug fixes only - patch level
  \# 14.8.10 14.9.1 new features - minor version level (tag for Maven, create branch)
  \# 14.8.10 15.1.1 new features - major version level (tag for Maven, create branch)
  \#
  \# The distinction between major and minor is arbitrary.
  \#
  \# Note that -beta releases will be to https://sourceforge.net/projects/jmol/files/Jmol-beta
  \# while full releases will be to https://sourceforge.net/projects/jmol/files/Jmol.
  \#
  \# 2. Create a new Jmol.\_\_\_\... line and remove \"Jmol.\_\_\_\" from the line for the
  \# previous release; failure to do remove this line will use the original release number,
  \# not the new one, since this is a property file.
  \#
  \# 3. Commit this change.
  \#
  \# 4. Run jsmol build_11_fromJmol.xml
  \#
  \# 5. Refresh the JSmol project
  \#
  \# 6. Run jsmol build_12_tosite.xml
  \#
  \# 7. Run jsmol build_13_tojs.xml
  \#
  \# 8. Run jmol build.xml (including dist, which also initiates a release now)
  \#
   
   
  \# TODO: fix UNDO
  \# TODO: check RN=X=NR stereo
  \# TODO: symop() is largely undocumented
  \# TODO: load CENTROID is udocumented ??
   
  \# NOTE: This is the older, non-SwingJS, version of Jmol.
   
  \# TODO: isosurface cavity delivers nonsense volume due to unclosed surface
   
   
  Jmol.\_\_\_JmolVersion=\"14.31.52\"
  also 15.1.52
   
  bug fix: JavaScript does not return to correct scrpt level after DELAY
   
  JmolVersion=\"14.31.51\"
  also 15.1.51 (take 2)
   
  new feature: ISOSURFACE DENSITY option
  \- checks for cryo-EM data from EBI/EMDB and, if that exists, uses it; otherwise uses x-ray diffraction data
  bug fix: problems with ISOSURFACE in 14.31.50
  bug fix: EM isosurface not saved in state.
   
  JmolVersion=\"14.31.50\"
  also 15.1.50
   
  bug fix: JSpecView upgrade for misc. JDXReader issues
  bug fix: Jmol file dropper not asking to resize (broken in 15.1.46/14.31.46)
  bug fix: Jmol not reading EBI cryo-EM files from density server.
  bug fix: Jmol not using EBI submap feature of density server for full-structure volumes
   
  new feature: ISOSURFACE \*\.../full
  \- returns the FULL EBI volume data, not just one localized around a structure
   
  JmolVersion=\"14.31.49\"
  also 15.1.49
   
  bug fix: JSpecView not using \#\#FIRSTX for diff-dup x values after first.
  bug fix: JSpecView version not showing
   
  new feature: isosurface \"\*em\"
  \- same as \*emdb, just simpler.
   
  JmolVersion=\"14.31.48\"
  also 15.1.48
   
  bug fix: JavaScript isosurface asynchronous file loader
  failing to finalize, causing refresh in later-called
  function to not return.
   
  bug fix: Filenames and directories with unicode accents not saved in ZIP, PNGJ, JMOL files.
   
  bug fix: Locally loaded JavaScript files not save in ZIP, PNGJ, JMOL
   
  JmolVersion=\"14.31.47\"
  also 15.1.47
   
  new feature: isosurface \"\*emdb/nnnn\"
  \- retrieves the cryo-EM surface EMD-nnnn
  \- uses http://ftp.ebi.ac.uk/pub/databases/emdb/structures/EMD-%file/map/emd\_%file.map.gz
  (https did not work in Java due to certificate issues)
   
  new feature: isosurface \"\*emdb/=xxxx\"
  \- looks up the EMDB id for the cryo-EM surface associated with pdb id xxxx
  \- first uses https://www.ebi.ac.uk/emdb/api/search/fitted_pdbs:%file?fl=emdb_id,map_contour_level_value&wt=csv
  \- then uses http://ftp.ebi.ac.uk/pub/databases/emdb/structures/EMD-%file/map/emd\_%file.map.gz
   
  new feature: isosurface \"\*emdb\" (or \"\*emdb/\" or \"\*emdb/=\")
  \- uses the current model\'s PDB ID with \*emdb/=xxxx\"
   
  JmolVersion=\"14.31.46\"
  also 15.1.46
   
  bug fix: Drag-drop of PNGJ can fail due to SCRIPT command not accepting \"spt::\" type identifier
   
  JmolVersion=\"14.31.45\"
  also 15.1.45
   
  bug fix: model kit changes for atomName and element not saved in state (since Jmol 14.28?)
   
  JmolVersion=\"14.31.44\"
  also 15.1.44
   
  bug fix: Incorrect implementation of double value from string in JCAMP-DX format
  bug fix: V3000 reader does not recognize 2D mol file setting
  bug fix: 2D-\>3D can invert stereocenters having C-H bond.
   
  JmolVersion=\"14.31.43\"
  also 15.1.43
   
  new feature: hbondHDistanceMaximum maximum O\--H distance in hydrogen bonds
  \- only in the case of actual hydrogen bonds, not pseudo-hydrogen bonds
  \- hbondsDistanceMaximum now aliased to hbondNODistanceMaximum for clarity
   
  JmolVersion=\"14.31.42\"
  also 15.1.42
   
  bug fix: GaussianReader fix for reading frequencies giving NullPointerException
   
  bug fix: mmCIF reader was requiring optional auth_XXXX fields
   
  bug fix: jspecview reading pimentoGCMS2.dx empty \$\$MODEL= causes NullPointerException
   
  bug fix: better MMFF94 and UFF for 2D -\> 3D
  new feature: adds MMFF2D and UFF2D forcefields that involve stronger
  fields for no-hydrogen (UFF2D) and added-hydrogen (MMFF2D) minimization
  new feature: adds set testflag2 TRUE to stop FILTER \"2D\" after first stage, before UFF2D+MMFF2D minimization
   
  JmolVersion=\"14.31.41\"
  also 15.1.41
   
  bug fix: (JSmol only - not SwingJS) modelkit bond assignment fails due to old transpiler bug
  \-- was failing to convert char to int and back properly
   
  JmolVersion=\"14.31.40\"
  also 15.1.40
   
  bug fix: eval(\"JSON\",json) fix to allow \[\...\] or {\...}
  bug fix: ellipsoid ISO saved in state with wrong size
   
  new feature: set checkCIR
  \-- retrieves the NCI/CADD Chemical Identifier Resolver URL
  \-- currently contacts chemapps.stolaf.edu/resolver
  \-- places return JSON information into \_.cirInfo
  \-- reports \_.cirInfo.status as \"OK\" if successful or \"unavailable\" if not
   
  new feature: Jmol\'s first load \'\$\' or https://cactus.nci.nih/gov call does checkCIR
   
  new feature: Loading cactus.nic.nih/gov/chemical/structure file will resolve that name
   
  JmolVersion=\"14.31.39\"
  also 15.1.39
   
  bug fix: GAMESS reader broken
   
  JmolVersion=\"14.31.38\"
  also 15.1.38
   
  bug fix: TopoCIF 0.9.2 upgrade for \_topol_node and \_topol_net
  bug fix: JSpecView SVG export missing in menu and broken
   
   
  JmolVersion=\"14.31.37\"
  also 15.1.37
   
  bug fix: removing default dependency for XmlUtils and PO
   
  JmolVersion=\"14.31.36\"
  also 15.1.36
   
  bug fix: capture broken in 14.31.34
   
  JmolVersion=\"14.31.35\"
  also 15.1.35
   
  adds GamessReader MOPAC parameters from F90 files provided by Jimmy Stewart for MO reading
  \-- note that GAMESS uses only s and p orbitals for the MOPAC option
  adds GamessReader MOPAC option
  \-- forces using MOPAC slaters rather than gaussian contraction when g.c. is present
  adds MoldenReader \[STO\] ANGS and MOPAC options (zeta in 1/Angs; apply MOPAC scaling)
   
  JmolVersion=\"14.31.34\"
  also 15.1.34
   
  bug fix: NBO type change not saved in state
  bug fix: NBO auxiliary files (output.36, output.46, etc.) not saved in PNGJ,JMOL,ZIP files
   
  JmolVersion=\"14.31.33\"
  also 15.1.33
   
  new feature: Allow replacement of PNG data in PNGJ
   
  x = load(\"toHenry2_pngj.png\",true)
  y = load(\"bob.png\")
  x.\_IMAGE\_ = y.\_DATA
  write var x \"toHenryFromBob.png\"
   
   
  JmolVersion=\"14.31.32\"
  also 15.1.32
   
  bug fix: isosourface MOLECULAR and SASURFACE should never drop below 1.5/(probe radius)
  bug fix: (second release) getProperty(\"isosurfaceData\") broken
   
  JmolVersion=\"14.31.31\"
  also 15.1.31
   
  bug fix: isosurface \... NCI \"\" broken (in 14.5.2)
  bug fix: plane definitions totally messed up in 14.31.26
   
  JmolVersion=\"14.31.30\"
  also 15.1.30
   
  bug fix: load ? outside of function duplicates next commands
  bug fix: (JS) Safari 14 not downloading files using DataURI
   
  JmolVersion=\"14.31.29\"
  also 15.1.29
   
  bug fix: FileDropper does not recognize .txt file as possible script
   
  JmolVersion=\"14.31.28\"
  also 15.1.28
   
   
  new feature: Jmol SMILES bond atropisomerism \^nm- and \^\^nm-
  \-- indicates atropisomerism (bond chirality in biaryl systems)
  \-- \^ and \^\^ for bonds similar to @ and and @@ for atoms
  \-- n and m are single-digit bond selectors, generally one of 1, 2, or 3
  \-- n = 1/2/3 means \"reference atom is first/second/third connection
  to the atom on the left; m = 1/2/3 the same for the atom on the right.
  \-- \^- and \^\^- same as \^22- and \^\^22-, respectively
  \-- example:
   
   
  load \$biphenol
  connect \@2 \@7 atropisomer
  print {\*}.find(\"SMARTS\",\"c1(O)cccc{c1\^\^-c2}ccccc2O\")
   
  ({1 6})
   
  Here the \"\^\^-\" is short for \"\^\^22- and refers to the two carbons with connected oxygen atoms:
   
  new feature: mol1.find(mol2, \"MAP\" + flags, format)
  \- creates a correlation map of atoms of mol1 to atoms of mol2
  \- mol1 and mol2 are atom sets such as {1.1} and {1.2}
  \- uses SMILES; Jmol SMILES directive flags such as \"hydrogen\" or \"open\" can be added
  \- format indicates the format to use for the results
  \- can be \"name\", \"index\", \"number\" or any valid label, such as \"%a %i\"
  \- defaults to \"number\"
  \- returns a map (associative array) containing keys:
  \- smiles: the SMILES string used for the match
  \- BS1 : atomset for mol1
  \- BS2 : atomset for mol2
  \- SMILEStoBS1 : array correlating SMILES atoms to BS1
  \- SMILEStoBS2 : array correlating SMILES atoms to BS2
  \- BS1toBS2 : array correlating BS1 to BS2 (indexes are for mol1; values are mol2)
  \- MAP1to2 : array of \[a,b\] pairs, where a is format for mol1, b is format for mol2
  \- key : format used in mapping
   
  \- example:
   
  load files \":caffeine\" \"\$caffeine\"
  info = {1.1}.find({2.1},\"map\", \"name\")
  print info.SMILES
  print info.key + \": \" + info.MAP1to2.format(\"JSON\")
   
  O=C1c2c3N(C)C(=O)N1C.\[n\]2(C)c\[n\]3
   
  name: \[ \[ \"O1\",\"O14\" \],\[ \"O2\",\"O4\" \],\[ \"N3\",\"N5\" \],\[ \"N4\",\"N10\" \],\[ \"N5\",\"N1\" \],
  \[ \"N6\",\"N8\" \],\[ \"C7\",\"C12\" \],\[ \"C8\",\"C7\" \],\[ \"C9\",\"C13\" \],\[ \"C10\",\"C3\" \],
  \[ \"C11\",\"C9\" \],\[ \"C12\",\"C6\" \],\[ \"C13\",\"C11\" \],\[ \"C14\",\"C2\" \] \]
   
  info = {1.1}.find({2.1},\"map hydrogen\", \"number\")
  print info.SMILES
  print info.key + \": \" + info.MAP1to2.format(\"JSON\")
   
  /hydrogen/O=C1c2c3N4\[C@@\](\[H\])(\[H\])\[H\].N51\[C@@\](\[H\])(\[H\])\[H\].C54=O.\[n\]62\[C@\](\[H\])(\[H\])\[H\].c6(\[H\])\[n\]3
   
  number: \[ \[ 1,14 \],\[ 2,4 \],\[ 3,5 \],\[ 4,10 \],\[ 5,1 \],\[ 6,8 \],\[ 7,12 \],
  \[ 8,7 \],\[ 9,13 \],\[ 10,3 \],\[ 11,9 \],\[ 12,6 \],\[ 13,11 \],\[ 14,2 \],\[ 15,21 \],
  \[ 16,18 \],\[ 17,20 \],\[ 18,19 \],\[ 19,22 \],\[ 20,23 \],\[ 21,24 \],\[ 22,15 \],\[ 23,17 \],\[ 24,16 \] \]
   
  bug fix: x.label(\"%a %D\") wrong value for %D
   
  JmolVersion=\"14.31.27\"
  also 15.1.27
   
  bug fix: {\*}.bonds.length not working
   
  bug fix: array.find(n) should not do a string seach and return match.
  \- return array of array indices, 1-based.
  \- example: \[11 3 1 2 1\].find(1) == \[3 5\], not \[1 3 5\]
   
  newly documented:
   
  Polyhedra command allows for min and max radius
  \-- polyhedra 2.8 3.0 \@3
   
  setting DSSR on the fly:
   
  model 1 property dssr \"1d66.dssr\" // file containing data
  model 1 property dssr @{load(\"1d66.dssr\")} // actual data
  select iloops
   
   
  4-order bond in MOL file using 14 for bond order
  \-- Jmol extension for MOL file format to allow 4-bond
  \-- example: \[Re2Cl8\](2-)
  \-- see https://en.wikipedia.org/wiki/Quadruple_bond
   
  5-order bond in MOL file using 15 for bond order
  \-- Jmol extension for MOL file format to allow 5-bond
  \-- example: \[Mo2Cl8\](4-)
  \-- see https://en.wikipedia.org/wiki/Quintuple_bond
   
  6-order bond in MOL file using 16 for bond order
  \-- Jmol extension for MOL file format to allow 6-bond
  \-- example: Mo2
  \-- see https://en.wikipedia.org/wiki/Sextuple_bond
   
   
  DRAW polygon \@face \@points
  \-- draws a filled polygon based on arrays of atom indices
  \-- \@face is an array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
  \-- for example:
   
  load \$p4
  x = {\*}.find(\"\*1\*\*1\",\"map\");
  draw ID p4r polygon @{x\[1\]} color red
  draw ID p4b polygon @{x\[2\]} color blue
  draw ID p4y polygon @{x\[3\]} color yellow
  draw ID p4g polygon @{x\[4\]} color green
   
   
  DRAW polyhedron \@faces \@points
  \-- draws sets of polygons based on arrays of atom indices
  \-- \@faces is an array of array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
  \-- for example:
   
  load \$caffeine
  draw polyhedron @{{\*}.find(\"\*1\*\*\*\*1\|\|\*1\*\*\*\*\*1\",\"map\")}
   
  load \$p4
  draw ID p polyhedron @{{\*}.find(\"\*1\*\*1\",\"map\")} color red
   
  POLYHEDRON ID xxx \@faces \@points
  \-- \@faces is an array of array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
   
  load \$p4
  polyhedra ID p4 @{{\*}.find(\"\*1\*\*1\",\"map\")}
   
  array.format(headings) Transform an array of arrays into an array of associative arrays based on \"column\" headings, and vice-versa. For example, if y = \[\[1,2\],\[3,4\]\], then \<b\>z = y.format(\[\"a\",\"b\"\])\</b\> will set z to \[ {{ \"a\": 1,\"b\": 2 }},{{ \"a\": 3, \"b\": 4 }} \]. And, in reverse, \<b\>z.format(\[\"a\",\"b\"\])\</b\> will be back to \[\[1,2\],\[3,4\]\]
  array.format(\"JSON\") Formats a serial or associative array as JSON.
  array.format(\"%5.3f\\t%5s\") Formats an array or array of arrays into a multiline string using sprintf format.
   
  arrayOfArrays.col(n) selects out the nth column from an array of arrays.
  For example, retrieving the third column from CSV data:
  col3 = load(\"data.csv\").split(\"\",true).col(3).
   
  SHOW CHEMICAL \-- fully described NIH/CADD options
   
  SHOW xxxx /yyyy Adding \"/xxxx\" to the command, such as SHOW file/cell will filter
  the output only to lines containing the text after the slash character.
   
  Jmol PolySMILES \-- described
   
  JmolSQL \-- more description; adds WHEREIN; replaces older \*\* notation
   
  load HISTORY \"saved.his\" \-- loads command history with script in saved.his
   
  load(filename, asbinary, async) \-- 3rd parameter loads file asynchronously in HTML5
   
  frame align \[modelNo\] \[pt\] \-- FIXED is assumed; used in state; shifts a model by a specific amount after removing any current frame alignment
   
  x.dot(y) for point.dot(plane)
   
  CIF 2.0 file reader added
   
  set zshadePower 0 \-- allows examination of depth buffer and writing to image for external processing
   
  Windows BMP image reading \-- reads 24-bit (full color) as well as 16-, 8-, 4-, 2-, and 1-bit color palette modes
  \-- 14-byte and 40-byte headers only; does not read compressed modes
   
  Write and data({atomset},type) expanded to: CIF\|CML\|CFI\|MOL\|PDB\|PQR\|SDF\|CD (ChemDoodle)\|JSON\|QCJSON\|V2000\|V3000\|XYZ\|XYZRN\|XYZVIB
   
  x.find(\"SMILES\",\"top\") \-- creates a topology SMILES, involving just \* and connections; does not include stereochemistry;
  \-- allows comparison of connection patterns without respect to any other consideration.
  \-- can be used to check equivalences in inorganic crystal structures.
  \-- example: load \$caffeine;\$ print {\*}.find(\"SMILES\",\"top\") =\> \*1(\*)\*(\*)\*2\*3\*(\*)\*1\*.\*2(\*)\*\*3
   
  load \"\" fill UNITCELL PRIMITIVE (for files that are conventional)
  load \"\" fill UNITCELL CONVENTIONAL (for VASP files, which are primitive cells)
   
  polyhedra WIGNER // Wigner-Seitz cell
  polyhedra BRILLOUIN // 1st Brillouin zone
  polyhedra BRILLOUIN 1 // 1st Brillouin zone
  polyhedra BRILLOUIN 2 // 2nd Brillouin zone
  polyhedra BRILLOUIN -1 // Wigner-Seitz cell
  polyhedra scale 3.0 BRILLOUIN 1 // scaled 1st Brillouin zone
   
  POLYHEDRA edgesOnly \-- shows just edges; operates on ALL polyhedra, not just selected; complements edges, noEdges, frontEdges
   
  select within(d, \$p1) where \$p1 is a polyhedron ID
  \-- d = 0 is \"on or within the polyhedron\"
  \-- d \< 0 is \"-d angstroms within polyhedron\"
  \-- d \> 0 is \"within d angstroms of polyhedron\"
   
  LOAD will read BZ2-compressed files
   
  WRITE \"SDF\" implements atom value V nnn \... information
  \-- requires assigning the data property name \"atom_values\" in the model\'s molData property
  \-- for example:
   
  \$ load \$2,3-dichlorobutane
  \$ molData = {\"atom_values\":\"chirality\"}
  \$ model properties \"molData\" molData
  \$ write dcb.sdf
   
  \-- note that if the model already has a molData property, then use the following to append to it:
   
  \$ molData = (\_M.molData ? \_M.molData : {})
  \$ molData.atom_values = \"chirality\"
  \$ model properties \"molData\" molData
   
  x = load(\"filename\",\"JSON\") \-- loads JSON data into variable
   
  {atom}.chirality \-- uses Cahn-Ingold-Prelog rules to assign R or S to a carbon center
  \-- ignores sulfur and nitrogen chirality, generally
   
  {atom}.cipRule \-- CIP sequence rule deciding this center; one of 1a, 1b, 2, 3, 4a, 4b, 4c, 5, or blank
   
  load =chebi/nnnnnn \-- chEBI 2D molecule load, with minimal 100-step minimization
   
  set debugHigh \-- same as set loglevel 6 - debugging only
   
  x.split(true) \-- does a white-space token split of the string value of x
   
  CALCULATE CHIRALITY {atom set} \-- optionally limited to the given atom set (or the currently selected atoms by default)
   
  set jmolInJSpecView \-- allows Jmol window to NOT be embedded in JSpecView when JSpecView is opened in Jmol; default TRUE
   
  WRITE ISOSURFACE \"t.pmesh\"; WRITE ISOSURFACE \"t.pmb\"
  \-- creates ASCII (.pmesh) or binary (.pmb) file (a Jmol-specific file format)
  \-- relatively compact format
  \-- can speed up loading of meshes and contours
  \-- for filled surfaces, use .jvxl instead
  \-- read back into Jmol using ISOSURFACE \"t.pmesh\"/\"t.pmb\"
  \-- note that binary files are NOT RECOMMENDED for JSmol because some platforms cannot read them locally
  \-- example:
   
  load \$methane
  isosurface plane {0 0 0 1} map vdw contours 20
  write ISOSURFACE contour.pmb
  isosurface contour.pmb
   
  set labelfor {atomset} \"value\"
  \-- allows setting of label without changing current selection
  \-- uses same syntax as LABEL command after {atomset}
  \-- for example:
   
  set labelfor \@atoms \@myLabel
  set labelfor {atomno \<= 3} @{\[\"a\",\"b\",\"c\"\]}
  set labelfor {\_C && chirality != \"\"} \"%\[atomname\] %\[chirality\]\"
   
  color NUCLEIC \-- for nucleic only (others will be grey) \-- based on DSSR nucleic color scheme: G green, C yellow, A red, T blue, U cyan
   
  set cartoonBlocks; set cartoonBlockHeight x.x \-- for nucleic only \-- uses DSSR data if present (using calculate structure DSSR or load =xxxx/dssr)
  \-- displays a DSSR block for each base based on dssr.nts.frame \-- x.x is height of box in Angstroms (default 0.5)
   
  color property DSSR type
  \-- where type is one of:
  bulges
  coaxStacks
  hairpins
  hbonds
  helicies
  iloops
  isoCanonPairs
  junctions
  kissingLoops
  multiplets
  nonStack
  nts
  pairs
  ssSegments
  stacks
  stems
  \-- color is based on index into the list of the given structures
  \-- 0 (not of that structure), 1 (first entry), 2 (second entry), etc.
  \-- for example:
   
  load =4fe5/dssr
  cartoons only;set cartoonSteps;
  color property dssr junctions
   
  x = {\*}.find(smartsString,\"map\") \-- returns an array of arrays of atom indices (0-based)
  \-- indicates exact correlation between atoms in {\*} and atoms of smartsString
  \-- only unique sets of atoms are found, not every possibility
  \-- for example:
   
  load \$caffeine
  s = show(\"smiles\") // N1(C)C(=O)c2c3N(C)C1=O.\[n\]2(C)c\[n\]3
  print {\*}.find(s,\"map\").format(\"JSON\")
  \[ \[ 0,1,12,13,11,6,4,5,2,3,9,10,8,7 \] \]
   
  load :caffeine
  print {\*}.find(s,\"map\").format(\"JSON\")
  \[ \[ 4,13,8,0,6,7,2,11,9,1,3,12,10,5 \] \]
   
   
  MACRO bz; createWS(\"p1\") (still not documented)
  \-- creates a Wigner-Seitz cell as polygon id \"p1\"
  \-- requires current unit cell to be primitive to work correctly
  \-- polyhedron can be shifted using POLYHEDRA OFFSET
  \-- default ID \"pbz1_1\_\" for just CREATEWS()
   
   
  POLYHEDRA UNITCELL
  \-- creates a polyhedron (12-gon in this case) around each of the
  currerntly selected atoms that has that bonding environment
  \-- DOES NOT require atoms at these positions - can simply use the
  unit cell and periodicity to find the relevant atom positions.
  \-- will check bonding as necessary using autobonding parameters
  \-- accepts all standard polyhedra options. For example:
   
  polyhedra 12,16 3.5 UNITCELL
   
  array.getProperty(\"xxxx\") \-- same as getproperty(array, \"xxxx\")
  \-- drills down into an array of associative arrays to get sublist
  \-- can be used with \[SELECT \... WHERE\]
   
  SELECT x where x is an array of integers or array of array of integers
   
  connect NBO \<nbotype\>
  \- connect atoms in the currently visible model using a resonance structure configuration found in an NBO .46 or .nbo file
  \- where \<nbotype\> is one of alpha\|beta\|46\|46a\|46b\|nrtstr_n\|nrtstra_n\|rs_n\|rsa_n\|rsb_n
   
  label %\[nbo\];
  \- label an atom using a resonance structure configuration found in an NBO .46 or .nbo file
  \- requires a previous connect NBO
   
  set nboCharges (default true)
  \- determines whether formal charges are also displayed with LABEL %\[nbo\]
   
  CONNECT for quintuple and sextuple bonds.
  \-- connect \@1 \@2 quintuple
  \-- connect \@1 \@2 sextuple
  \-- readily saved in state
  \-- saving in MOL file as bond type 15 and 16
   
  set labelOffset \[mode sx sy sz ax ay az\]
  set labelOffset \[sx, sy, sz\]
  set labelOffset \[mode, sx, sy, sz, ax, ay, az\]
   
  where
   
  sx,sy,sz are screen coord offsets
  \-- applied after view rotation
  \-- sy \> 0 LOWERS label
  ax,ay,az are xyz position (in Angstroms; applied before view rotation)
  mode == 0 indicates xyz position is absolute and sx sy sz are Angstroms
  mode == 1 indicates xyz position is relative to atom position and sx sy sz are Angstroms
  mode == 2 indicates xyz is absolute, and sx sy sz positions are screen pixels
  mode == 3 indicates xyz is relative, and sx sy sz positions are screen pixels
  defaults: mode == 1; ax = ay = az = 0
   
  getProperty(\"cifInfo\", \"c:/temp/test.cif\")
  \-- reads CIF file data in structured format
  \-- automatically uses CIF 1.0 or CIF 2.0, as needed.
  \-- if file name is missing, uses current model file
   
   
  load AUDIO audiofilename
  \-- JavaScript can read WAV, MP3, and OGG files
  \-- application can read WAV files
   
  polyhedra AUTO \...
  \-- sets polyhedron radius automatically, using \"MAXIMUM GAP\" rule
  \-- see Zur Abgrenzung der Koordinationssphäre und Ermittlung der Koordinationszahl in Kristallstrukturen
  G. O. Brunner, D. Schwarzenbach, Zeitschrift fur Kristallographie - Crystalline Materials, 1971, vol 133, issues 1-6 127-133
  http://www.degruyter.com/view/j/zkri.1971.133.issue-1-6/zkri.1971.133.16.127/zkri.1971.133.16.127.xml?rskey=sfBNTx&result=1
   
  polyhedron -x.x \....
  \-- sets maximum radius for gap calculation to be x.x
   
  print \@1.label(\"%\[unitid\]\")
  \-- generates unit IDs for atoms or residues
  \-- unit IDs are a proposed general standard for representing atoms and residues in biomolecules
  \-- see http://rna.bgsu.edu/main/rna-3d-hub-help/unit-ids
  \-- options follow \"-\":
   
  \$ print {atomno=3}.label(\"%\[unitid\]\") // includes residue and atom
  \|1\|A\|G\|1\|OP1\|\|\|
   
  \$ print {atomno=3}.label(\"%\[unitid-r\]\") // residue only
  \|1\|A\|G\|1\|\|\|\|
   
  \$ print {atomno=3}.label(\"%\[unitid-mr\]\") // adds model id
  1EHZ\|1\|A\|G\|1\|\|\|\|
   
  \$ print {atomno=3}.label(\"%\[unitid-mra\]\") // full unitID
  1EHZ\|1\|A\|G\|1\|OP1\|\|\|
   
  \$ print {atomno=3}.label(\"%\[unitid-mrat\]\") // full unitID, right-trimmed
  1EHZ\|1\|A\|G\|1\|OP1
   
  \-- Note that the full 8-line unit ID is produced under all circumstances.
  This is important, because string-matching of unit ids will not work
  without all fields completed. For example:
   
  \|1\|A\|G\|1
   
  would match
   
  \|1\|A\|G\|11
   
  without the closing \"\|\". Likewise,
   
  \|1\|A\|G\|11
   
  is not a match for the insertion residue
   
  \|1\|A\|G\|11\|\|\|3\|
   
  \-- \[Editorial note: I agree that it was ill-advised to put the insertion
  code at the end. This makes it impossible to efficiently match
  residues in full-atom unit IDs.\]
   
  \-- Note that in an actual atom label, one needs to add \"\\n\" at the end
  and have the label in quotes in order to avoid having \"\|\" mean \"new line\"
   
  label \"%\[unitid\]\\n\"
   
  not just
   
  label %\[unitid\]
   
  This is a consequence of having defined \"\|\" as new line early on in Jmol
  development.
   
  select within(\"1ehz\|1\|A\|G\|45\|\|\|\|\")
  print within(\"1ehz\|1\|A\|G\|45\|\|\|\|\")
  \-- unit IDs
  \-- see http://rna.bgsu.edu/main/rna-3d-hub-help/unit-ids
  \-- used for annotations, validations, dssr, and rna-3d processing
  \-- pdbid\|model\|chain\|RESNAME\|resno\|ATOMNAME\|altcode\|inscode\|symmetry
  \-- can truncate trailing (but not leading) pipe symbols
  1ehz\|1\|A\|G\|15, \|1\|A\|G\|15\|C2
  \-- requires at minimum a model number, chain, and residue number
  \|1\|A\|\|15
  \-- ATOMNAME blank indicates full residue, with altcode indicating \"this alt_id or no alt_id\" (a configuration)
  \-- ATOMNAME nonblank indicates one atom, with altcode indicating \"exactly this alt_id\" (a location)
  \-- can be multiple, white space, comma, \"\]\", \"\[\", and double quote ignored
  1ehz\|1\|A\|G\|15\|\|\|\|,1ehz\|1\|A\|U\|59\|\|\|\|,1ehz\|1\|A\|C\|60\|\|\|
   
  select shortcuts for nucleic acid structures
  \-- for example: select junctions; select kissingloops
  \-- activated after load =xxxx/dssr or calculate structure dssr
  \-- includes:
  \"\@bulges within(dssr,\'bulges\')\",
  \"\@coaxStacks within(dssr,\'coaxStacks\')\",
  \"\@hairpins within(dssr,\'hairpins\')\",
  \"\@hbonds within(dssr,\'hbonds\')\",
  \"\@helices within(dssr,\'helices\')\",
  \"\@iloops within(dssr,\'iloops\')\",
  \"\@isoCanonPairs within(dssr,\'isoCanonPairs\')\",
  \"\@junctions within(dssr,\'junctions\')\",
  \"\@kissingLoops within(dssr,\'kissingLoops\')\",
  \"\@multiplets within(dssr,\'multiplets\')\",
  \"\@nonStack within(dssr,\'nonStack\')\",
  \"\@nts within(dssr,\'nts\')\",
  \"\@naChains within(dssr,\'naChains\')\",
  \"\@pairs within(dssr,\'pairs\')\",
  \"\@ssSegments within(dssr,\'ssSegments\')\",
  \"\@stacks within(dssr,\'stacks\')\",
  \"\@stems within(dssr,\'stems\')\",
   
   
  mapOfMaps.array(k)
  \-- generates an array of maps from a map of maps by
  storing all top-level map keys under key k in lower-level map
  \-- reversed by another .array(k)
  \-- causes a script exception if mapOfMaps is not a map of maps
   
  arrayOfMaps.array(k)
  \-- generates a map of maps from an array of maps by
  removing each map\'s key k and using that as the key for that map value
  \-- reversed by another .array(k)
  \-- causes a script exception if arrayOfMaps is not an array of maps or key k is not present in all maps
   
  Jmol SMILES/SMARTS generic polySMILES polyhedron option \@PHn
  \-- does a SMILES search for the local coordination environment around a center.
  \-- particularly valuable for inorganic compounds and metallic or intermetallic network crystal structures
   
  write CIF (only minimal)
   
   
  \@1.find(\"crystalClass\", pt)
  \-- generates a list of points based on a model\'s crystal class (point group)
  \-- uses \@1 just to find the unit cell and space group
  \-- optional pt is used as a generator (defaults to \@1)
  \-- example:
  load =ams/calcite 1
  x = \@3.find(\"crystalClass\")
  print pointgroup(x).name
  draw points \@x
  polyhedra ID p {0 0 0} to \@x
   
   
  pointgroup(\"spacegroup\", \@1)
  \-- analyzes the point group (crystal class) of a crystal.
  \-- uses three irrational-coordinate points to generate all possible operators
  \-- creates a map with keys (somewhat variable depending upon axes present):
   
  C2
  C3
  Ci
  Cs
  S6
  detail
  distanceTolerance
  linearTolerance
  nAtoms
  nC2
  nC3
  nCi
  nCn
  nCs
  nS6
  nSn
  nTotal
  name
  points
  principalAxis
   
   
   
  x = pointgroup(\[array of points\],center)
  \-- center is optional, defaulting to average of the points
  \-- returns a map:
  pts = \[ {-1.0132 0.585 0.0012999999},{1.0132 0.585 0.0012999999},{0.0 -1.17 0.0012999999} \]
  print pointgroup(pts,{0 0 0})
  {
  \"C2\" :
  \[
  {0.8660127 -0.50001717 0.0022222984}
  {-0.8660127 -0.50001717 0.0022222984}
  {0.0 0.99999756 0.002222217}
  \]
  \"C3\" :
  \[
  {0.0019245904 -0.0011111083 -0.99999756}
  \]
  \"Cs\" :
  \[
  {0.0019245904 -0.0011111085 -0.99999756}
  {-0.49998164 -0.866036 0.0}
  {0.49998164 -0.866036 0.0}
  {1.0 0.0 0.0}
  \]
  \"S3\" :
  \[
  {0.0019245904 -0.0011111083 -0.99999756}
  \]
  \"center\" : {0.0 0.0 0.0}
  \"detail\" : \"\# 3 atoms;\"
  \"distanceTolerance\" : 0.2
  \"linearTolerance\" : 8.0
  \"nAtoms\" : 3
  \"nC2\" : 3
  \"nC3\" : 1
  \"nCi\" : 0
  \"nCn\" : 4
  \"nCs\" : 4
  \"nS3\" : 1
  \"nSn\" : 1
  \"nTotal\" : 12
  \"name\" : \"D3h\"
  \"principalAxis\" : {0.0019245904 -0.0011111083 -0.99999756}
  \"principalPlane\" : {0.0019245904 -0.0011111085 -0.99999756}
  }
   
   
  calculate symmetry polyhedra {atomset}
  \-- selectively calculates polyhedra.
  \-- for example: calculate symmetry polyhedra {polyhedra(4)}
   
  calculate symmetry polyhedra id
  \-- selectively calculates polyhedra for a given ID.
  \-- for example: calculate symmetry polyhedra \"poly1\"
   
   
  \_hoverLabel
  \-- reports general hover label set by hover command
   
  \_hoverEnabled
  \-- reports if hover is enabled or not
   
  /invertStereo/ flag for SMARTS search
  \-- allows quick check for enantiomers
  \-- example: select search(\"/invertStereo/C\[C\@H\](Br)CC\") will match (R)-2-bromobutane
  even though it is for (S)-2-bromobutane
   
  {\*}.find(\"SMILES/open\")
  \-- generates OpenSMILES string for selected atoms
  \-- applies OpenSMILES aromaticity rules for 5-, 6-, and 7-membered rings
  \-- not chemical \-- allows exocyclic c=C bonds and \[nH\] in 6-membered rings
  \-- also adds atom class if property_atomClass is nonzero
  \-- for example:
   
  \$ load \$2-butanol
  \$ \@2.property_atomclass=2
  \$ \@3.property_atomclass=3
  \$ \@5.property_atomclass=5
  \$ print {\*}.find(\"smiles/open\")
   
  C\[C\@H:2\](\[OH:5\])\[CH2:3\]C
   
  set window width height
  set window \[width height\]
  set window \"xxx.png\"
   
   
  point(unitcell, {i, j, k})
  \-- returns the Cartesian point corresponding to a specific coordinate in a unit cell system.
  \-- unitcell is an array of the form \[origin, va, vb, vc\]
  \-- {i j k} is a point in the unit cell
  \-- for general use \-- does not require actual setting of the model\'s unit cell
   
  UNITCELL TRANSFORM \@m4x4
  \-- direct 4x4 matrix transformation of a unit cell
   
  unitcell(\"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\")
  \- array of center and three vectors
  \- example:
  \$ print unitcell(\"a=10,b=10,c=20,alpha=90,beta=90,gamma=129\")
  {0.0 0.0 0.0}
  {10.0 0.0 0.0}
  {-6.293203 7.7714605 0.0}
  {-8.742278E-7 -1.8328565E-6 20.0}
   
  load \... unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
   
  unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
  \-- only the numbers are read; everything else is ignored, so order is important here
  \-- uses the format created by show unitcell/a
   
  unitcell RECIPROCAL 2
  \-- as integer, multiples of pi
   
  unitcell reciprocal x.x
  \-- allows scaling of reciprocal cell, similar to unitcell(\"reciprocal\", x.x)
   
  expanded unitcell() function
  \-- adds additional types: \"A\", \"B\", \"C\", \"I\", \"F\"
  \-- default is the lattice type of the model\'s space group
  \-- not just cubic; \"BCC\" is converted to \"I\"
  \-- for example:
   
  load =ams/silicon 15 packed // Cmca
  draw id \"uc\" diameter 0.1 unitcell mesh nofill color black
  unitcell @{unitcell(\"primitive\")}
  color unitcell red
  unitcell 0.1
  axes unitcell
  axes on
   
   
  calculate hydrogens TRUE
  \-- calculates hydrogens and multiple bonding
  \-- same as
   
  calculate hydrogens
  connect aromatic modify
  calculate aromatic
   
  \-- similar to, but not identical to set pdbAddHydrogens
  \-- allows reasonable addition of multiple bonds to proteins after loading
   
   
   
   
  JmolVersion=\"14.31.26\"
  also 15.1.26
   
  new feature: \$isosurface.getProperty(\"values\"), \$isosurface.getProperty(\"vertices\") corrected for invalid vertices
   
  bug fix: getProperty(\"isosurfaceData.vertices\") returning too many vertices
  \- retrieves only the vertices that are on the surface, not excluded vertices
  \- retrieves only vertices for selected sets if using SET or SUBSET
  \- works best with ISOSURFACE sasurface (much faster than SOLVENT or MOLECULAR)
  \- can be used with ISOSURFACE solvent or ISOSURFACE molecular
  with careful adjustment of solvent probe diameter (1.2 recommended, not 1.4)
  and RESOLUTION
  \- with 1.4, there is a tendency to get interior artifacts
  \- note that this function will return \"null\" if there is no isosurface or if
  no single isosurface is selected (by issuing ISOSURFACE ID xxx ON, for instance)
   
  new feature: getProperty(\"isosurfaceData.allVertices\")
  \- returns all vertices, even those excluded as interior artifacts or from unselected sets
   
  load =6nef
  isosurface sasurface
  x=\$isosurface1.getproperty(\"vertices\")
  {\*}.property_d = {\*}.distance.min(x)
  color property_d
  slab 50; slab on
  draw points \@x // to visualize the surface points themselves
   
  bug fix: Cif2Reader should accept UTF-8 signature \"BOM\" of three bytes 0xEF 0xBB 0xBF (not 0xFEFF)
   
  JmolVersion=\"14.31.25\"
  also 15.1.25
   
  bug fix: isosurface set 1 showing 2nd largest, should show largest
  bug fix: save state for isosurface with one set off by one
  bug fix: getProperty(\"isosurfaceData\") fails for pocket cavities
   
  JmolVersion=\"14.31.24\"
  also 15.1.24
   
  note: isosurface \#sets is from print getProperty(\"shapeInfo.Isosurface\[1\].volume\").length
  bug fix: isosurface set 0 not working
  bug fix: calculate surfacedistance fails \-- wrong parameter in Java method call
  bug fix: MoldenReader requires \[MO\] to be last tag
  bug fix: MoldenReader should not report energy units (not always eV)
  bug fix: DnD script into script console should run that script.
  bug fix: AboutDialog using old splash image
   
  JmolVersion=\"14.31.23\"
  also 15.1.23
   
  bug fix: STL and hermite display missing last two residues of trace
   
  JmolVersion=\"14.31.22\"
  also 15.1.22
   
  new feature: isosurface subset \[1 3 5\] cavity vdw
  \- allows more than one set to be displayed
   
  new feature: isosurface cavity 1.2 50 vdw
  \- increases maximum envelope radius from 10 to 50
  \- note that large envelope radii can produce artifacts for pocket cavities
  \- for example:
   
  load =1wp1 filter \"biomolecule 1\"
  isosurface set 1 select {protein} only pocket cavity 3 20
  isosurface slab none slab plane x=0
   
  JmolVersion=\"14.31.21\"
  also 15.1.21
   
  new feature: InChIKey generation:
  load \$morphine; print {\*}.find(\"inchi\", \"key\");
  \- can be combined with any other valid inchi flag:
  load \$morphine;print {\*}.find(\"inchi\",\"srel key\");
   
  new feature: {\*}.inchi(options) same as {\*}.find(\"inchi\",options);
  load \$morphine; print {\*}.inchi(\"key\");
   
  new feature: InChI or InChIKey from SMILES using .inchi():
  print \"CCCC\".inchi() // uses load(\"\$CCCC\")
  print \"CCCC\".inchi(\"key\")
   
  new feature: InChI or InChIKey from NCI or PubChem shortcut using .inchi():
  print \"\$caffeine\".inchi();
  print \"\$CCCC\".inchi();
  print \":caffeine\".inchi(\"key\");
  print \":smiles:CCCC\".inchi();
   
  new feature: InChI or InChIKey from any MOL file data source using .inchi():
  print load(\"foo.mol\").inchi(\"key\");
   
  new feature: InChIKey from InChI:
   
  \$ x = \":morphine\".inchi()
  \$ print x
  InChI=1S/C17H19NO3/c1-18-7-6-17-10-3-5-13(20)16(17)21-15-12(19)4-2-9(14(15)17)8-11(10)18/h2-5,10-11,13,16,19-20H,6-8H2,1H3/t10-,11+,13-,16-,17-/m0/s1
  \$ print x.inchi(\"key\")
  BQJCRHHNABKAKU-KBQPJGBKSA-N
   
   
   
  bug: \"xxx\".find(\"sequence\") assumes xxx is a set of one-character residue IDs
   
  new feature: adds \"xxx\".find(\"sequence\",true)
  \- case-sensitive text search
   
  new feature: adds \"xxx\".find(\"sequence\",false)
  \- case-insensitive text search
   
   
  JmolVersion=\"14.31.20\"
  also 15.1.20
   
  bug fix: GamessReader should read ENERGY, MP2, CSDD, and CSDD(T) energy types (Mark Perri)
  \- adds \_M.EnergyType
   
  bug fix: VaspOutcarReader upgrade for Vasp6
   
  new feature: initialize INCHI
  \- for JavaScript specifically, loads the inchi-wasm module asynchronously.
  \- allows the very first call to {\*}.find(\"inchi\") to be active.
  \- note that a very first call to Jmol.evaluateVar(applet,\"{\*}.find(\'inchi\')\") will still fail.
   
  new feature: {\*}.find(\"inchi\")
  new feature: {\*}.find(\"inchi\",flags)
  \- generates InChIs from modelset atoms
  \- integrates jni-inchi-0.7-jar-with-dependencies.jar
  \- uses inchi-wasm for JavaScript (R.Apodaca https://github.com/rapodaca/inchi-wasm)
  \- flags include (https://www.inchi-trust.org/technical-faq-2):
  perception flags: DoNotAddH SNon NEWPSOFF
  stereo flags: SRel SRac SUCF
  more flags: NEWPSOFF SUU SLUUD RecMet FixedH KET 15T
  java-only flags: key outputsdf (Java only; still no InChIKey for JavaScript)
  \- JavaScript is InChI 1.05; Java is still 1.03
  \- note: JavaScript-only directories \_WASM and \_ES6 should not be processed by Google Closure Compiler
   
  JmolVersion=\"14.31.19\"
  \-- was released as an overwrite of 14.31.18 :(
   
  JmolVersion=\"14.31.18\"
  also 15.1.18
   
  bug fix: MacSpartan Release 1.0.3 (ancient!) skips orientation and orbitals
  bug fix: SHOW SPACEGROUP fails for nonstandard space group (=ams/quartz)
   
   
  new feature: Topology CIF (TopoCifParser.java) reading of \_topol_xxx records
  topoCIF filter \"topos_type=x\" where x is v, vw, hb, or some concatentation of those using \"+\"
  topoCIF filter \"topos_ignore\" skips reading of \_topol records, reading as standard CIF
   
  undocumented: set hiddenLinesDashed (14.8.0)
   
   
  JmolVersion=\"14.31.17\"
  also 15.1.17
   
  bug fix: print 2 \> 1.0 gives false. typo introduced 2020.10.02 causes int\[\>,\<,\>=,\<=\] float to fail
  bug fix: minimizer step reports should be in user units, not native
  bug fix: minimizer initial/final reports should state \"/mol\" for units
   
  JmolVersion=\"14.31.16\"
  also 15.1.16
   
  new feature: (undocumented) now(\"message\")
  new feature: now(\"message\",\"format\")
   
  bug fix: print load(\"t.tar\") should act as load(\"t.tar\|.\") to give directory
  bug fix: MO linear combination should not show type in info
  bug fix: MO squared should show \^2 in info
   
  // there is no 14.31.15
   
  JmolVersion=\"14.31.14\"
  also 15.1.15
   
  new feature: TAR file reader with zip-like entry loading
  load \"t.tar\|guest/77317/output.log\"
   
  new feature: GenNBOReader supports older NBO 3.0 output.properties rather than missing .46 labels file
  new feature: NBO command expanded to allow named orbitals
  NBO \"C1-C2\"
  NBO TYPE PNBO \"C1-C2\"
   
  JmolVersion=\"14.31.13\"
  also 15.1.14
   
  bug fix: MoldenReader fails to read \[5F\] if that record is after the \[MO\] block.
  bug fix: GenNBOReader does not accept spherical s, p designations: 151 152 153 (wh6-a.31)
   
  JmolVersion=\"14.31.12\"
  also 15.1.14
   
  bug fix: minimization constraint broken in 14.29.45
   
  JmolVersion=\"14.31.11\"
  also 15.1.13
   
  bug fix: adds fix in script compiler for nonbreaking
  space nbsp; \\u00a0 from clipping browser text
   
  JmolVersion=\"14.31.10\"
  also 15.1.12
   
  bug fix: dots -1.0 does not imply ONLY
   
  JmolVersion=\"14.31.9\"
  also 15.1.11
   
  bug fix: set pdbaddhydrogens does not work with PDB files that have some H atoms (but no multiple bonds)
  bug fix: MOVETO quaternion jumps (seconds=0) if crude check for change fails
   
  JmolVersion=\"14.31.8\"
  also 15.1.10
   
  new feature: point(\[\"{1,2,3}\",\"{2,3,4}\",\....\])
  bug fix: large integer number != operator failure
  bug fix: fuxyz vs. fxyz and uxyz
  distribution: JSpecview not built in 14.31.5
   
  JmolVersion=\"14.31.7\"
  also 15.1.9
   
  bug fix: PSE file saved to PNGJ may not fully reload (missing surface, for example)
  bug fix: atom.occupancy of 0.01 saved as 0.0
   
  JmolVersion=\"14.31.6\"
  also 15.1.8
  bug fix: msCIF reader not reading ICDD Fourier modulated file.
   
  JmolVersion=\"14.31.5\"
   
  bug fix: https for NMRDB
  bug fix: JSpecview applies \#\#SHIFTREFERENCE as HZ for data in PPM
  bug fix: JSpecview must ignore \#\#SHIFTREFERENCE for JEOL, at least for \$\$ JEOL NMR v1.10
   
  JmolVersion=\"14.31.4\"
   
  bug fix: print format(\"%0.-3s\", \"testing\") \"-\" does nothing
   
  new feature: isosurface S1 VAL \[points or atoms\] SELECT\....
  \- calculates isosurface values for a set of points or atoms
  \- values are created during surface constructions, not after
  \- for solvent and molecular surfaces, negative value is \"inside\"; positive is \"outside\"
  \- surfaces that are not calculated will give 0 for all values
   
  new feature: \$s1.getProperty(\"values\");
  \- retrieves the array of values produced by isosurface s1 VAL
  \- example:
   
  load \$caffeine
  isosurface s1 value {\*} select {!\_H} only vdw 50% translucent
  {\*}.property_d = \$s1.getproperty(\"value\")
  color property_d
   
  bug fix: NWChem reader does not ignore file-save data block properly
  bug fix: get property fileInfo initially or after ZAP throws exception
  bug fix: isosurface map colorscheme \"rwb\" fails, whereas color isosurface \"rwb\" works
   
  JmolVersion=\"14.31.3\"
   
  bug fix: Jmol app does not allow width smaller than about 350 pixels
   
  JmolVersion=\"14.31.2\"
   
  bug fix: draw pointgroup C2 3 draws all C2 axes, not just the third
   
  JmolVersion=\"14.31.1\"
   
  bug fix: SYNC/sockets should not automatically subscribe to CLICK (which includes drag events)
  bug fix: \"WRITE IMAGE width height\" (with no file name) causes array out of bounds exception
  bug fix: SYNC command sending not working with raw JSON or Jmol associative arrays
   
  JmolVersion=\"14.31.0\"
   
  new feature: Switch to Java 7, allowing for string-based switch and Files.readAllBytes().
   
  bug fix: ellipsoids \"csa\" scale 0.5 on does not scale
  bug fix: implicit refresh required after translateSelected
   
  new feature: Gaussian reader reads NMR shielding tensors as \"csa\"
  for example:
   
  load EtOH-nmr.out
  frame 2;
  wireframe only
  ellipsoids set \"csa\" scale 0.5
  ellipsoids on
   
  new feature: Gaussian reader reads NMR_J\_coupling data
  new feature: atom properties can be float\[\]\[\] arrays
  \-- for atom-atom values
  new feature: MEASUREMENT property_xxx
  \-- for 2D float\[\]\[\] properties
  new feature: MEASUREMENT VALUE x.x
  \-- sets a fixed value for a standard measurement
  new feature: measurement unit \"+xxx\" means abs(value)
  \-- specifically, \"+hz\" useful for calculation data
  new feature: measurement \"+hz\" units automatically use property_J values
  new feature: MEASUREMENT \"\<unit\>\" where \<unit\> is valid measurement unit
  new feature: measure() allows \"property_xxx\"
  new feature: measure() allows \"\<unit\>\"
  for example:
   
  load EtOH-nmr.out
  frame 2;
  print @\@3.property_J.format(\"JSON\")
   
  \>\> \[ \[ 0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,-5.8511596,132.96,0.0,-2.16701,3.6352599,1.4761999,1.5346,-0.042426,-11.6895 \] \]
   
  print measure(@\@2, {model=2}, \"property_J\", \"\").format(\"JSON\")
   
  \>\> \[ 124.307,0.0,132.96,119.271,9.69322,0.75008297,4.29308,-6.40836,115.875 \]
   
   
  measure @\@2 @\@3 \"+hz\" // \"+hz\" for absolute value and indicates we want to use this property
   
  measure @\@2 @\@3 property_J \"hz\"
   
  print measure(@\@2, @\@3, \"property_J\", \"hz\")
   
  \>\> property_J 133.0 \"133.0 hz\" C2/2 \#2 H3/2 \#3
   
  print measure(@\@2, @\@8, \"property_J\", \"+hz\")
   
  \>\> property_J 6.4 \"6.4 hz\" C2/2 \#2 O8/2 \#8
   
   
  new feature: SYNC sockets completely rewritten, allowing for substantially more
  feedback and simpler JSON-based interface. Many features of the
  Molecular Playground now implemented in Jmol itself. Features include:
  \- simplification of sockets, allowing for just one that is use for
  input and outoput
  \- default short-message callbacks for all significant callbacks
  \- added set XxxxCallback SYNC:ON and SYNC:OFF for subscribing to
  full callback Object\[\] data information.
  \- better JSON creation/parsing
  \- simpler class structure
  \- allows Molecular Playground-like gestures to be socket-defined.
   
  This from org.openscience.jmol.appl.jsonkiosk.JsonNioService:
   
  /\*\*
  \* A class for interacting with Jmol over local sockets.
  \*
  \* See also org.molecularplayground.MPJmolApp.java for how this works.
  \* Note that this service does not require MPJmolApp \-- it is a package
  \* in the standard Jmol app.
  \*
  \* Listens over a port on the local host for instructions on what to display.
  \* Instructions come in over the port as JSON strings.
  \*
  \* This class uses the Naga asynchronous socket network I/O package (NIO), the
  \* JSON.org JSON package and Jmol.
  \*
  \* http://code.google.com/p/naga/
  \*
  \* Initial versions of this code, including the JSON-base protocol were created
  \* by Adam Williams, U-Mass Amherst see http://MolecularPlayground.org and
  \* org.openscience.jmol.molecularplayground.MPJmolApp.java
  \*
  \* \<code\>
  \*
  \* Sequence of events:
  \*
  \* 1) Jmol initiates server listening on a port using the JmolScript
  \* command with an arbitrary negative port number.
  \* (-30000 used here just for an example):
  \*
  \* sync -30000
  \*
  \* This can be done also through the command line using
  \*
  \* jmol -P -30000
  \*
  \* or
  \*
  \* jmol \--port -30000
  \*
  \* Jmol will respond to System.out:
  \*
  \* JsonNioServerThread-JmolNioServer JsonNioServerSocket on 30000
  \*
  \*
  \* 2) Client sends handshake to port 30000. As with all communications to this service,
  \* there must be no new-line characters (\\n) ANYWHERE in the JSON being sent EXCEPT
  \* for a single message terminator:
  \*
  \*
  \* {\"magic\": \"JmolApp\", \"role\": \"out\"}\\n
  \*
  \* where \"out\" here indicates that this socket is for Jmol (reply) output.
  \*
  \* Jmol will reply with the 30-byte response:
  \*
  \* {\"type\":\"reply\",\"reply\":\"OK\"}\\n
  \*
  \* (The client may see only 29 bytes, as it may or may not strip the final \\n.)
  \*
  \* Optionally, the client may also indicate a specified port for Jmol input.
  \* But typically this is just the currently active port.
  \*
  \* {\"magic\": \"JmolApp\", \"role\": \"in\"}\\n
  \*
  \* Jmol will reply with
  \*
  \* {\"type\": \"reply\", \"reply\": \"OK\"}\\n;
  \*
  \*
  \* 3) Client sequentially sends Jmol script commands over the \"in\" socket:
  \*
  \* {\"type\": \"command\", \"command\": command}
  \*
  \* where required command is some JSON-escaped string such as \"rotate x 30\" or \"load \$caffeine\".
  \* For example:
  \*
  \* {\"type\": \"command\", \"command\": \"var atoms = {\_C or \_H};select atoms\"}\\n
  \*
  \*
  \* For the rest of this discussion, we will use the Jmol command that communicates with another Jmol instance
  \* rather than this JSON context:
  \*
  \* SYNC 30000 \"var atoms = {\_C or \_H};select atoms\"
  \*
  \* in this case.
  \*
  \*
  \* 4) Jmol throughout this process is sending replies that come
  \* from the Jmol Statuslistener class. For example:
  \*
  \* {\"type\":\"reply\",\"reply\":\"SCRIPT:script 8 started\"}
  \* {\"type\":\"reply\",\"reply\":\"SCRIPT:Script completed\"}
  \* {\"type\":\"reply\",\"reply\":\"SCRIPT:Jmol script terminated\"}
  \*
  \* Note that your client will be subscribed to many of the Jmol status callbacks
  \* (see org.openscience.jmol.app.jmolpanel.StatusListener), including:
  \*
  \* LOADSTRUCT
  \* ANIMFRAME
  \* SCRIPT
  \* ECHO
  \* PICK
  \* CLICK
  \* RESIZE
  \* ERROR
  \* MINIMIZATION
  \* STRUCTUREMODIFIED
  \*
  \* All scripts and callback messages run in order but asynchronously in Jmol. You do not need
  \* to wait for one script to be finished before issuing another; there is a queue that handles that.
  \* If you want to be sure that a particular script has been run, simply add a MESSAGE command
  \* as its last part:
  \*
  \* sync 30000 \"background blue;message The background is blue now\"
  \*
  \* and it will appear as a SCRIPT callback:
  \*
  \* {\"type\":\"reply\",\"reply\":\"SCRIPT:The background is blue now\"}
  \*
  \* after which you can handle that event appropriately.
  \*
  \* The SCRIPT callback can be particularly useful to monitor:
  \*
  \* sync 30000 \"backgrund blue\"
  \*
  \* {\"type\":\"reply\",\"reply\":\"SCRIPT:script compiler ERROR: command expected\\n\-\-\--\\n \>\>\>\> backgrund blue \<\<\<\<\"}
  \*
  \* Note that the ERROR callback does not fire for compile errors,
  \* only for errors found while running a parsed script:
  \*
  \* {\"type\":\"reply\",\"reply\":\"ERROR:ScriptException\"}
  \*
  \* Note that all of these messages are \"thumbnails\" in the sense that they are just a message string.
  \* You can subscribe to a full report for any of these callbacks using \'SYNC:ON\' for the
  \* callback function:
  \*
  \* set XxxxxCallback SYNC:ON
  \*
  \* For example, issuing
  \*
  \* sync 30000 \"load \$caffeine\"
  \*
  \* gives the simple reply:
  \*
  \* {\"type\":\"reply\",\"reply\":\"LOADSTRUCT:https://cactus.nci.nih.gov/chemical/structure/caffeine/file?format=sdf&get3d=true\"}
  \*
  \* but after
  \*
  \* sync 30000 \"set LoadStructCallback \'SYNC:ON\'
  \*
  \* we get additional details, an array of data with nine elements:
  \*
  \* {\"type\":\"reply\",\"reply\":\[\"LOADSTRUCT\",
  \* \"https://cactus.nci.nih.gov/chemical/structure/caffeine/file?format=sdf&get3d=true\",
  \* \"file?format=sdf&get3d=true\",
  \* \"C8H10N4O2\", null, 3, \"1.1\", \"1.1\", null\]}
  \*
  \* Exact specifications for these callbacks are not well documented.
  \* See org.jmol.viewer.StatusManager code for details.
  \*
  \* Remove the callback listener using
  \*
  \* set XxxxxCallback SYNC:OFF
  \*
  \* Note that unlike Java, you get only one SYNC callback; this is not an array of listeners.
  \*
  \*
  \* 5) Shutdown can be requested by sending
  \*
  \* {\"type\": \"quit\"}\\n
  \*
  \* or by issuing the command
  \*
  \* sync 30000 \"exitjmol\"
  \*
  \*
  \* Note that the Molecular Playground implemented an extensive set of gesture-handling methods
  \* that are also available via this interface. Many of these methods utilize the JmolViewer.syncScript()
  \* method, which directly manipulates the display as though someone were using a mouse.
  \*
  \* {\"type\" : \"move\", \"style\" : \"rotate\", \"x\" : deltaX, \"y\", deltaY }
  \* {\"type\" : \"move\", \"style\" : \"translate\", \"x\" : deltaX, \"y\", deltaY }
  \* {\"type\" : \"move\", \"style\" : \"zoom\", \"scale\" : scale } (1.0 = 100%)
  \* {\"type\" : \"sync\", \"sync\" : syncText }
  \* {\"type\" : \"touch\",
  \* \"eventType\" : eventType,
  \* \"touchID\" : touchID,
  \* \"iData\" : idata,
  \* \"time\" : time, \"x\" : x, \"y\" : y, \"z\" : z }
  \*
  \* For details on the \"touch\" type, see org.jmol.viewer.ActionManagerMT::processEvent
  \*
  \* Note that all of the move and sync commands utilize the Jmol sync functionality originally
  \* intended for applets. So any valid sync command may be used with the \"sync\" style. These include
  \* essentially all the actions that a user can make with a mouse, including the
  \* following, where the notation \<\....\> represents a number of a given type. These
  \* events interrupt any currently running script, just as with typical mouse actions.
  \*
  \* \"centerAt \<int:x\> \<int:y\> \<float:ptx\> \<float:pty\> \<float:ptz\>\"
  \* \-- set {ptx,pty,ptz} at screen (x,y)
  \* \"rotateMolecule \<float:deltaX\> \<float:deltaY\>\"
  \* \"rotateXYBy \<float:deltaX\> \<float:deltaY\>\"
  \* \"rotateZBy \<int:degrees\>\"
  \* \"rotateZBy \<int:degrees\> \<int:x\> \<int:y\>\" (with center reset)
  \* \"rotateArcBall \<int:x\> \<int:y\> \<float:factor\>\"
  \* \"spinXYBy \<int:x\> \<int:y\> \<float:speed\>\"
  \* \-- a \"flick\" gesture
  \* \"translateXYBy \<float:deltaX, float:deltaY\>\"
  \* \"zoomBy \<int:pixels\>\"
  \* \"zoomByFactor \<float:factor\>\"
  \* \"zoomByFactor \<float:factor\> \<int:x\> \<int:y\>\" (with center reset)
  \*
  \*
  \* \</code\>
  \*/
   
  JmolVersion=\"14.30.3\"
   
  new feature: FAHReader FAH:: reads FoldingAtHome Top.json and FrameNNN.json files
  \-- FAH:: is required for Frame files but not the Top file.
  \-- automatic calculation of structure using DSSP
  \-- Both files are required; three load options:
   
  LOAD FILES \"ViewerTop.json\" + \"ViewerFrame22.json\" // explicit joining to two files
   
  LOAD ViewerTop.json;
  LOAD XYZ FAH::ViewerFrame22.json // first the atoms, then the coordinates
   
  LOAD FAH::ViewerFrame22.json // just the coordinates with associated ViewerTop.json assumed present
   
  \-- Subsequent calls to LOAD XYZ will replace coordinates and recalculate DSSP only.
   
   
  JmolVersion=\"14.30.2\"
   
  bug fix: CrystalReader fails to read models in CRYSTAL17 double-walled nanotube file tn0.out
   
  JmolVersion=\"14.30.1\"
   
  new feature: (undocumented) set picking dragMolecule
  \-- acts like set picking dragSelected
  \-- LEFT-drag to translate; ALT-LEFT-drag to rotate
  \-- useful for two more molecules (covalently bonded units)
   
  new feature: set picking dragModel
  \-- acts like set picking dragMolecule or dragSelected
  \-- LEFT-drag to translate; ALT-LEFT-drag to rotate
  \-- useful for two more models not loaded using set appendNew FALSE
   
   
  JmolVersion=\"14.30.0\"
   
   
  bug fix: CrystalReader for slab nanotubes.
  \- note that we are not processing the nonstandard helical symmetry operations
   
  Note - The move to a new minor version (14.30) is due to changes in the
  \-\-\-\-\-- Jmol Java/SwingJS application, not the JavaScript version. In particular,
  \-\-\-\-\-- changes in the way the org.openscience.jmol.app classes are
  \-\-\-\-\-- organized required taking this step.
   
  new feature: set minimizationMaxAtoms
  \- maximum number of atoms allowed for MMFF minimization
  \- defaults to 200
   
  new feature: MEASURE SEARCH \"{\[H\]}CC{\[H\]}\"
  \- uses SMARTS searching, selecting only the specified atoms
  (in this case, all vicinal hydrogen atoms attached to carbon)
  \- actually available but undocumented since 2013
   
  new feature: SET MEASUREMENTUNITS HZ
  \- for example, set measurementUnits HZ; MEASURE SEARCH \"{\[H\]}CC{\[H\]}\" will display all 1H-1H coupling constants for a model
  \- display calculated three-bond (standard vicinal) H-H J coupling constants (SMARTS {\[H\]}CC{\[H\]}) calculated
  using Haasnoot-Altona-Karplus substituent electronegativity-adjusted algorithm instead of distances
  \- If there are fewer than three substituents on each central atom, or if
  either central atom is not carbon, defaults to general Karplus equation.
  \- see org.jmol.quantum.NMRCalculation.java for algorithm and bibliographic details
  \- expanded from use in solid-state NMR to any model EXCEPT magres files,
  which instead use HZ in association with solid-state tensors
   
  new feature: SET MEASUREMENTUNITS NOE_HZ
  \- adds NOE calculation for H atoms that are more then three bonds apart
  along with vicinal and geminal
  \- not validated; from Janocchio 1.1 (https://sourceforge.net/projects/janocchio/)
   
  new feature: Janocchio application included as a plugin (preliminary)
  \- Java only; totally experimental; VERY preliminary
  \- org.openscience.jmol.app.janocchio
  \- required some refactoring of Jmol app classes
  \- commit number 22001!
   
  new feature: LOAD \... CENTROID
  \- for molecular crystal structures
  \- loads one or more unit cells (as specified by {nx ny nz})
  exploring covalent bonding so that molecules that have their centroid
  (center of geometry) within the specified block of cells are built.
  \- available but undocumented since 2011
  \- example: load =cod/1001253 {1 1 1} centroid
  note that {1 1 1} here is unnecessary, as it is the default
   
  bug fix: \"DOMReader\" not \"DOMReadaer\" in File Manager
   
  JmolVersion=\"14.29.55\"
   
  bug fix: show chemical image has no image
  bug fix: dotted lines with antialiasing are too thin and half the spacing
   
  JmolVersion=\"14.29.54\"
   
  new feature: ELLIPSOID ID xx axes \[\...\] \[\...\] \[\...\]
  new feature: ELLIPSOID ID xx axes \[ \[\...\]\[\...\]\[\...\] \]
  new feature: ELLIPSOID ID xx axes \[ pt pt pt \]
  new feature: ELLIPSOID ID xx axes matrix3f
  new feature: ELLIPSOID ID xx scale \[ a b c \]
  new feature: ELLIPSOID ID xx scale pt
   
  new feature: set macroDirectory \[default: https://chemapps.stolaf.edu/jmol/macros\]
  \- holds macros.json, which points to macro files
  \- no longer hard-coded into Jmol
   
  new feature: adds MACRO topond
  new feature: adds MACRO crystal
  new feature: adds MACRO topology
  new feature: adds filter \"topos\" to load command to allow for hypothetical unit cells with dimension a=1.
   
  bug fix: symop(\@1,\@2,\"matrix\") should give an array of matricies, one for each relevant operation
  bug fix: print (-0.0001).format(\"%3.2f\") should print 0.00, not -0.00
  bug fix: CRYSTAL reader fixes for TOPOND output
  bug fix: MOLDEN fix for allowing beta set to start with (nCoef + 1)
   
  JmolVersion=\"14.29.53\"
   
  bug fix: PyMOL PSE reader broken for broken PyMOL 2.3.0
   
  JmolVersion=\"14.29.52\"
   
  bug fix: CASTEP reader broken by Siesta %block check in Resolver
   
   
  JmolVersion=\"14.29.51\"
   
  bug fix: (undocumented) measure ID \"xx\" \... buggy
   
  -fixes measure vertical center when using ID
  -adds id, hidden, visible to getproperty measurementInfo
   
  JmolVersion=\"14.29.50\"
   
  bug fix: SiestaReader upgrade
  bug fix: load =3dna/val validation loading does not work
   
  JmolVersion=\"14.29.49\"
   
  bug fix: isosurface cutoff +0.3 does not work to indicate positive only for difference electron density maps
  bug fix: load =3dna/val validation loading does not work (same reason as 14.29.28)
   
  JmolVersion=\"14.29.48\"
   
  bug fix: LOAD xxxx:: broken in 14.29.25
   
  JmolVersion=\"14.29.47\"
   
  bug fix: standard PDB files (no hydrogens and no multiple bonds) should not require /aromaticPlanar/
  in search() selection.
   
  JmolVersion=\"14.29.46\"
   
  bug fix: ModelKit menu broken in 14.29.45
   
  JmolVersion=\"14.29.45\"
   
  bug fix: Java applet fails with class not found / static reference error
  bug fix: Spartan reader files missing from applet JAR collection
  bug fix: SDF writing should preserve order of user data
   
  bug fix: symop(\@3, \@4, \"array\") should return the full set of all the operators that map atom 3 to atom 4
   
  new feature intersection(ptLine, vLine, ptCenter, radius)
  \-- intersection of a line with a sphere \-- return list of 0, 1, or 2 points
   
  new feature: (array-of-hash).pivot(key)
  \-- turns an array of hashes into a hash of arrays of hashes
  \-- like a pivot table for an array, but based on the value of a hash
  key within each hash element of the array, not the element itself
  \-- returns a (hash-of-arrays-of-hashes) of the array elements grouped
  by the stringified values of the specified key.
  \-- for example:
   
  a = \[
  {label:\"C3\", id:1},
  {label:\"C3\", id:2},
  {label:\"C2\", id:3}
  \]
   
  a.pivot(\"label\") = {
  \"C3\":\[{label:\"C3\", id:1}, {label:\"C3\", id:2}\],
  \"C2\":\[{label:\"C2\", id:3}\]
  }
   
  new feature: (array-of-hash).pivot(key1, key2, \...,sep)
  \-- returns a (hash-of-array-of-hash) of the array elements grouped by the values of these keys,
  combined as a string using the separator given as the last parameter
  \-- for example:
   
  \$ load =ams/halite 1 packed
  \$ invariants = symop(\@3,\@3,\"array\")
  \$ uniqueOps = invariants.pivot(\"label\", \"axispoint\", \"axisVector\", \"+\")
   
  This code is cataloging all of operators of space group \#255 (F m 3 m) that
  leave atom 3 unchanged \-- invariant. There are 48 such operations, but some of
  them are about the same axis. The two rotations for a given C3 or C4 are now combined
  into one element of uniqueOps, since they both have the same label, axispoint, and axisVector,
  just different rotations.
   
  new feature: SHOW xxxx/!whatever
  \-- show lines without whatever using /!
   
  new feature MODELKIT command
  \-- particularly designed for crystallographic work
  \-- turning the modelkit on/off - same as SET MODELKITMODE:
   
  modelkit (ON)
  modelkit OFF
   
  \-- configuration options include the following, where (xxx) is optional, CAPS is default:
   
  MODELKIT addHydrogens \[TRUE\|false\]
  MODELKIT clickToSetElement \[TRUE\|false\]
  MODELKIT showSymopInfo \[TRUE\|false\]
   
  MODELKIT (mode) MOLECULAR
  MODELKIT (mode) view
  MODELKIT (mode) edit
  MODELKIT
  MODELKIT (unitcell) EXTEND
  MODELKIT (unitcell) packed
   
  MODELKIT (edit) APPLYFULL
  MODELKIT (edit) applyLocal
  MODELKIT (edit) retainLocal
  MODELKIT MODELKIT
  MODELKIT (view) symop \[n\]
  MODELKIT (view) symop \"x,-y,z\"
  MODELKIT (view) symop \[\[4x4 matrix\]\]
   
  MODELKIT (view) offset {i j k}
   
  MODELKIT center \@n
  MODELKIT center {point} (can be fractional by adding \"/1\" to at least one coord)
  MODELKIT center {atoms}
   
  MODELKIT (set) element \[name or symbol\]
   
   
  \-- configuration options can be given sequentially within one MODELKIT command or in individual commands
   
   
  \-- examples:
   
  modelkit mode view symop 5 center \@3
  modelkit mode view symop 5 center \@3 offset {0 0 0} // unitized \[0,1)
   
  \-- action options include alternatives the commands in bold (ASSIGN is undocumented):
   
  modelkit ROTATE \... (for example, ROTATE BOND \@1 \@2 degrees)
  modelkit ROTATESELECTED \...
  modelkit ASSIGN ATOM \@1 \[symbol\|pl\|mi\]
  modelkit ASSIGN BOND \@1 \[0,1,2,3,4,5,p,m\]
  modelkit ASSIGN CONNECT \@1 \@2
   
  new feature DRAW SYMOP \@2 OFFSET {1 0 0}
   
  \-- allows lattice OFFSET, where {0 0 0} is always into the unitcell \[0, 1)
   
   
  bug fix: MINIMIZE CONSTRAINT for dihedral does not work.
  new feature set mkAddHydrogens default true; set false to not add H atoms when working with modelkitmode
   
  JmolVersion=\"14.29.44\"
   
  bug fix: 0 + {3.4, 0, 0} should give 3, not 0
  bug fix:
   
  JmolVersion=\"14.29.43\"
   
  bug fix: navigate TRACE does not work in JavaScript
  bug fix: navigate TRACE followed by \"quit\" in console will not restart
   
  JmolVersion=\"14.29.42\"
   
  bug fix: MolReader not assigning \_M.dimension to \"2D\" or \"3D\", just the overall auxiliaryInfo.dimension
   
  JmolVersion=\"14.29.41\"
   
  bug fix: CrystalReader does not skip over INFORMATION or WARNING line in CRYSTAL output files
   
  bug fix: symop(\"x,y,z\",{0 0 1}) does not return correct value for unit cells oriented by a b c axes
   
  bug fix: OutputManager and FileManager fix for WRITE PDB \"https://\...\" sending information to a server
   
  bug fix: JSmolJME.js miscodings cause error message in JSME
   
  bug fix: nmr_predict_HC.htm not correlating signals to structure correctly
   
  bug fix: JSpecView peak tabs for simulation or correlation in JmolJDX not proper width
   
  JmolVersion=\"14.29.40\"
   
  bug fix: centerAt AVERAGE fix
   
  JmolVersion=\"14.29.39\"
   
  new feature: capture SCRIPT \"some script\"
  \- captures the given script
  new feature: DELAY 1 while capturing inserts a one-second delay into the GIF animation
  \- thus, the following is a +/-20-degree looping rock
  around the Y axis with a 2-second wait at each end:
   
  CAPTURE \"t.gif\" LOOP SCRIPT \"rotate y 20 20;delay 2;rotate y -40 -40;delay 2;rotate y 20 20;\"
   
  bug fix: JSpecView inline loading fails due to null file name assignment - now \"\[inline\]\"
  bug fix: JSpecView inline loading does not save data needed for export SOURCE
   
   
  JmolVersion=\"14.29.38\"
   
  bug fix: modelkit needs more slop for touch drag release and clicking
   
  new feature: CRYSTAL TOPOND TRHO and TLAT reader
  \-- reads critical point information in Bader analysis
   
  JmolVersion=\"14.29.37\"
   
  new feature: MO titleformat \"\...%3.1E\"\...\" allows rounding of energy value
  bug fix: (Java only) Jmol console does not accept paste with first character = \'\\n\'
   
  JmolVersion=\"14.29.36\"
   
  bug fix: getProperty(\"filecontents\",filename) does not work.
   
  JmolVersion=\"14.29.35\"
   
  bug fix: Jmol.jar does not contain JSpecView class files
   
  JmolVersion=\"14.29.34\"
   
  bug fix: processing of MagneticCIF \_space_group_magn.transform_BNS_Pp_abc \'-a+b,c,a+b;1/2,1,1/2\'
  fails
   
  JmolVersion=\"14.29.33\"
   
  bug fix: (JavaScript only) in state creation for wireframe and measure
  for integer Angstrom size, for example WIREFRAME 1.0
   
  JmolVersion=\"14.29.32\"
   
  bug fix: (JavaScript only) script with raw {\...} expression fails to compile
   
  JmolVersion=\"14.29.31\"
   
  bug fix: (JavaScript only) ModelKit checkboxes broken in atom submenu. (JSmol jsmoljs/JmolMenu.js)
   
  JmolVersion=\"14.29.30\"
   
  RELEASE NOTE: JmolApplet\*.jar Java files are no longer distributed in JSmol.zip.
  See the main release zip file for these.
   
  bug fix: H\--Y hydrogen bonds miscalculated due to length maximum miscoded in 14.29.27
  // JmolVersion=\"14.29.30\" 01/27/2019 \-- fixes bug of 10/29/2018
   
  JmolVersion=\"14.29.29\"
   
  new feature: print intersection(point vLine center radius) // 11/28/18
  \- returns a list of 0 to 2 points representing the intersection of
  \- a line through point with vector vLine and a sphere of radius about center
  \- allows for 3D building with constraints of a screen coordinate and a
  distance from an atom
   
  doc fix: intersection(point1 point2 point3) should be intersection(point1 vector1 point2)
  \- closest point to point2 on a line through point1 in the direction vector1
   
  bug fix: intersection() function changes value of point2
   
  bug fix: CrystalReader not reading vibration data for fragment calculation
   
  JmolVersion=\"14.29.28\"
   
  bug fix: modelkit appending broken in 14.29.25 10/10/18
   
  new feature: assign atom \"C\" {2 2 2}
  \- adds an unbonded atom at the given position
   
  JmolVersion=\"14.29.27\"
   
  new feature: CrystalReader auxiliary info:
  \*
  \* primitiveToCrystal M3 transforming primitive lattice to conventional lattice
  \*
  \* mat4PrimitiveToCrystal M4 for use in transforming symmetry operations
  \*
  \* mat4CrystalToPrimitive M4 convenience inverse of mat4PrimitiveToCrystal
  \*
  \* fileSymmetryOperations List\<String\> symmetry operators (primitive)
  \*
  \* Drawing primitive unitcell operations:
  \*
  \* ops = \_M.fileSystemOperations
  \*
  \* DRAW SYMOP @{ops\[2\]}
  \*
  \* If using the conventional cell, you can use its operators, or you can
  \* limit yourself this primitive subset using:
  \*
  \* mp2c = \_M.mat4PrimitiveToCrystal
  \*
  \* mc2p = \_M.mat4CrystalToPrimitive
  \*
  \* DRAW SYMOP @{mc2p \* ops\[2\] \* mp2c}
  \*
  bug fix: CrystalReader not showing proper primitive cell with UNITCELL PRIMITIVE
  bug fix: missing == for matrix3f and matrix4f
  bug fix: draw symop with offset unitcell misses planes
  bug fix: calculate hbond too generous for H\--Y bond length \-- max set at 2.2 Angstroms
  bug fix: Jmol application \"first frame\" toolbar button broken
  bug fix: script \"inline\" broken
   
  JmolVersion=\"14.29.26\"
   
  bug fix: unitcell command with fractional translation fails
  bug fix: CRYSTAL slab file can end up with emtpy-atom model
   
  JmolVersion=\"14.29.25\"
   
  bug fix: MCIF (magnetic cif) reader does not handle symmetry operations with n/16.
   
  JmolVersion=\"14.29.24\"
   
  bug fix: set language broken for Jmol application
  bug fix: CRYSTAL reader can read one last 0-atom model
  bug fix: 3-membered aziridine with non-H substituent should be chiral.
  bug fix: isosurface \"?\" fails in JavaScript
   
  JmolVersion=\"14.29.23\"
   
  bug fix: draw HKL {1 2 2} (undocumented) not working
  bug fix: draw PLANE \@pickedList not working
  bug fix: draw intercept unitcell PLANE \@pickedList not working
   
  JmolVersion=\"14.29.22\"
   
  bug fix: (JSmol only) menu items that are checkboxes do not work
   
  https://sourceforge.net/p/jsmol/code/HEAD/tree/trunk/dist/tmp/coremenu.z.js?format=raw
  https://sourceforge.net/p/jsmol/code/HEAD/tree/trunk/dist/tmp/corejsvmenu.z.js?format=raw
   
  can be placed in j2s/core as a quick fix
   
  JmolVersion=\"14.29.21\"
   
  bug fix: set measurement 5 (integer; pixels) produces no line.
  bug fix: polyhedra flat restored
   
  JmolVersion=\"14.29.20\"
   
  feature change: removes (older, nonfunctional) NBO plug-in. (See GitHub Jmol-SwingJS)
  new feature: allows plugin.properties to contain \";disabled\", removing it from the Plug-In menu
  new feature: adds ISOSURFACE \[f1, filename1, f2, filename2, \...\]
  \- allows linear combination of isosurfaces
  \- all grids must be identical (not checked internally - no error if this is not the case)
  \- example is comparing crystal surface struture with and without binding of a surface molecule
  \- e.g. ISOSURFACE \[1, \"PtO.cube\", -1, \"Pt.cube\", -1, \"O.cube\"\]
  \- can map a plane
  \- e.g. ISOSURFACE PLANE x=0.1 map \[1, \"PtO.cube\", -1, \"Pt.cube\", -1, \"O.cube\"\]
  \- recommend using ISOSURFACE CACHE to convert to JVXL before saving as PNGJ
   
   
  JmolVersion=\"14.29.19\" // 2018.08.31
   
  bug fix: LOAD \<old CRYSTAL output file\> may not work (CrystalReader.java)
  bug fix: LOAD \... supercell fails with multiple models (XtalSymmetry.java)
  bug fix: state creation Spacefill output \"2\" not \"2.0\" (missing PT.escF(f) call in StateCreator.java)
   
  JmolVersion=\"14.29.18\" // 2018.06.16
   
  bug fix: (JavaScript) modulation vector state in PNGJ or state not read back correctly from data
  (\"1.4E-45\" read as 1.399999\...e-45)
  bug fix: SHOW SPACEGROUP with group 167 will show too many n-glides; three are g-glides
   
  JmolVersion=\"14.29.17\" // 2018.06.15
   
  bug fix: magnetic modulations not factoring in static moment correctly
  bug fix: symop(\@1, \@2, \"id\") does not return 1-N id of operation
  bug fix: show spacegroup fails to show detailed operation list (broken in 14.20.5 8/30/17)
  bug fix: getproperty spacegroupinfo broken for incommensurate cases
  bug fix: unitcell \"-a,-b,c;0,0,0.50482\" not working
  bug fix: unitcell(\"-a,-b,c;0,0,0.5\") not working
  bug fix: cif reader does not recognize PRIMITIVE keyword
  bug fix: Guassian reader can fail if no lines are present after vibration section
   
  JmolVersion=\"14.29.16\" // 2018.06.06
   
  bug fix: unitcell(\"a=10 b=10,c=20,alpha=90,beta=90,gamma=129\") crashes Jmol
  bug fix: pointgroup(x) crashes Jmol when x is a set of points
  bug fix: UNITCELL parent not working
  bug fix: Brillouin Zone id set to \"\" for unknown reason
  bug fix: SMILES allene R/S chirality broken for some connections
  \- print \"C1.CC=\[C@@\]=\[CH\]1\".find(\"smiles\",\"chirality\").join(\"\") should be PP, not MM
   
  bug fix: undocumented unitcell {1500500500 1500500501 1} not working
  \- notation for expanding cell=555 to 1000 cells (1000jjjkkk-1999jjjkkk)
  \- due to large integer not being stored in float properly in Java
  \- related to 1505050 1505051, which does work (expands capability to 100 cells, 100jjkk-199jjkk)
   
  bug fix: load xxxx FILL UNITCELL broken (should not need \"conventional\" or \"primitive\")
   
  bug fix: MSCIFReader not recognizing atom_site_Fourier_wave_vector_q1_coef
   
  bug fix: Magnetic incommensurate files crashing unnecessarily
   
  new feature: getproperty spaceGroupInfo
   
   
  JmolVersion=\"14.29.15\"
   
  new feature: print {xxx}.find(\"SMILES/molecule\",\"CC\...\")
  new feature: print {xxx}.find(\"SMARTS/molecule\",\"CC\...\")
  \- molecule-based SMILES or SMARTS
  \- returns an array of matching molecules in {xxx}
  \- array.count gives number of matching molecules
   
  bug fix: \[array\].distance.min(\[array\]) does not work
   
  bug fix: Bilbao reader does not allow for a blank line that is \" \"
   
  bug fix: CrystalReader not reading vibrations properly for filter \"CONV\"
   
  bug fix: SMILES should allow \[C@+1\]
   
  JmolVersion=\"14.29.14\"
   
  bug fix: MO calculation can truncate MO if moleule is shifted too far prior to creation of MO
   
  bug fix: MOL reader user data column-81 continuation \'+\' fix
   
  bug fix: LOAD OFFSET option can skip first atom
   
  bug fix: CIPChirality \-- Rule 6 adds set ciprule6full option for rr bicyclo\[2.2.2\]octane in/out business
  bug fix: CIPChirality \-- Rule 5 adds needed S-ref
  bug fix: CIPChirality \-- Rule 4b/Rule 5 ordering correction
  bug fix: CIPChirality \-- should indicate M/P for allene-centered spiro case BH64_084
  bug fix: CIPChirality \-- should indicate \"e/z\" instead of E/Z\" for special cases of a single enantiomorphic pair
  bug fix: CIPChirality \-- duplicates and mass Rule 2 fix JL_008
   
  JmolVersion=\"14.29.13\"
   
  new feature: running CALCULATE CHIRALITY will generate
  a CIPInfo entry in the model\'s auxiliary info
  array indicating the decision
  points in the stereochemical analysis:
   
  \$ load \$inositol
  \$ select \@14
  \$ calculate chirality
  R
  \$ print \_M.CIPInfo.C14
  O8 \-\-\-\-\-\-\-\-\-\-\-\-\--
  1a
  C13 \-\-\-\-\-\-\-\-\-\-\-\-\--
  (R)lll
  4b
  (R)ll
  C16 \-\-\-\-\-\-\-\-\-\-\-\-\--
  1a
  H20 \-\-\-\-\-\-\-\-\-\-\-\-\--
   
   
  \- building of this structure disabled using SET TESTFLAG2
   
   
  new feature: \"\<smiles string\>\".find(\"smiles\",\"chirality\")
  \- creates an array indicating the stereochemical designator (R,S,r,s,M,P,m,p,E,Z) at each atom in the SMILES string
  \- no structure is necessary
  \- for example:
   
  \$ load \$1,4-dihydroxycyclohexane
  \$ calculate chirality
  rr
  \$ show smiles
  \"O\[C@\@H\]1CC\[C@\@H\](O)CC1\"
  zap
  \$ print \"O\[C@\@H\]1CC\[C@\@H\](O)CC1\".find(\"smiles\",\"chirality\").format(\"JSON\")
  \[ \"\",\"r\",\"\",\"\",\"r\",\"\",\"\",\"\" \]
   
  \$ print \"\[C@\@H\]1(C)CC\[C\@H\]2C(C)C.C1\[C@\@H\]2O\".find(\"smiles\",\"chirality\").format(\"JSON\")
  \[ \"R\",\"\",\"\",\"\",\"S\",\"\",\"\",\"\",\"\",\"S\",\"\" \]
   
  bug fix: CIP chirality did not recognize large conjugated rings as \"mancude-like\"
  bug fix: model kit should not change selection when inverting a stereocenter
   
  bug fix: WRITE xxx.PDB not writing CONECT records
   
  JmolVersion=\"14.29.12\"
   
  bug fix: jsmol.php security fix for sites implementing their own Info.serverURL
   
  bug fix: CrystalReader filer \"conv\" fix
   
  bug fix: MSCIFReader not recognizing atom_site_Fourier_wave_vector_q\_coef
  bug fix: MSCIFReader not recognizing atom_site_Fourier_wave_vector_q\<n\>\_coef and \_x,\_y,\_z in same block
   
  bug fix: GaussianReader broken for high-precision frequency data (broken in 14.29.10)
   
  new feature: GaussianReader orientation filters (default is ALL)
  \-- filter \'orientation:input\' (includes Z-Matrix)
  \-- filter \'orientation:standard\'
  \-- filter \'orientation:all\'
  \-- note that vibrations are only returned if orientation is ALL or STANDARD
   
  new feature: CrystalReader returns atom property_irreducible:
  \-- select property_irreducible \> 0
  \-- display property_irreducible \> 0
   
  new feature: CrystalReader adds ellipsoid set \"raman\"
   
   
  JmolVersion=\"14.29.11\"
   
  bug fix: CrystalReader not handling symmetry for filter \"conv\"
  bug fix: CrystalReader not properly generating vibrational modes
   
  code: refactored for SwingJS
  code: refactored CrystalReader
   
  JmolVersion=\"14.29.10\"
   
  bug fix: GaussianReader for fixed atoms in freq calculation
   
  JmolVersion=\"14.29.9v\"
   
  bug fix: NBO
   
  JmolVersion=\"14.29.9\"
   
  bug fix: NBO \-- normalizations validated using allyl.nn for all types
   
  code: total switch to javajs.util.BS from javajs.util.BS
   
  JmolVersion=\"14.29.8\"
   
  bug fix: NBO
   
  JmolVersion=\"14.29.7\"
   
  bug fix: NBO
   
   
  JmolVersion=\"14.29.6\"
   
  bug fix: Matrix4f, Matrix3f should be output in format consistent with an matrix, not an array
  \-- should not have space between opening and closing brackets
  \-- should not use commas (not a critical distinction)
   
  \[\[0.8362213 -0.5062382 0.21084802 52.988747\]
  \[0.5394281 0.8285579 -0.15003058 20.076633\]
  \[-0.09874859 0.23919612 0.96593684 46.393887\]
  \[0.0 0.0 0.0 1.0\]\]
   
  bug fix: genNBO reader failing for G orbitals (even though we cannot process them, the reader at least load them
   
  new feature: set infoFontSize
  \-- for MO and NBO command
  \-- default 20
   
  bug fix: red file load error message is too small to read
  \-- font size increased to 20
   
  code: modular loading of F,G,H,I MO calculations only when needed
   
  JmolVersion=\"14.29.5\" // released 2018.02.08
   
  bug fix: (Java application only) Incorrect class file in Jmol.jar causes BOUNDBOX ON to fail
   
  JmolVersion=\"14.29.4\" // released 2018.02.07
   
  bug fix: set hbondsrasmol false fails with O atom-only HOH group
  bug fix: calculate pointgroup does not change with new atom positions
   
  JmolVersion=\"14.29.3\" // released 2018.02.03
   
  bug fix: mac cut/paste enabled for Macs
  bug fix: set autobond corrected
  bug fix: changing an atom\'s element should delete all partial charges
  bug fix: load AUDIO \"xxx.wav\" broken in Java
  bug fix: load AUDIO \"xxx.wav\" broken in JavaScript
  bug fix: loading of pdb file does not report HET = \.... to console
  bug fix: CONTACT leading to no contacts crashes Jmol.
  bug fix: load FILES with filter does not work
  bug fix: load =xxxx/val with filter does not save in state
  solution was to change \"+\" to \"-\" to indicate special two-file loading in this case
   
  new feature: set label picking icon in application
  new feature: set label picking does not require shift for drag
  new feature: set label picking allows double-click to set the label
   
  new feature: drag-drop of PNGJ into script opens editor (for movie.spt; use not implemented)
   
  new feature: set allowAudio (default TRUE)
   
  new feature: AUDIOcallback
  \- used to continue after completion of an audio clip
  \- parameter is a hashtable with information about the audio clip
   
  new feature: load AUDIO \"xxx.wav\" FILTER \"\...options\...\"
  \- filter options include:
  \- id=\'\....\' an identifier for this audio clip
  \- loop loop until told to stop
  \- start=\'\...\', play=\'\...\', stop=\'\...\', ended=\'\...\' callback scripts allowed
  \- single word arguments allowed - for example, id=a2 ended=audioDone()
   
  note: These features will be included in a future AUDIO command
   
  JmolVersion=\"14.29.1\" // released 2018.01.25
   
  new feature: select peptide, defined as:
  protein && within(chain,monomer\>1)&!within(chain,monomer\>12)
   
  bug fix: isosurface EDS not working for mmCIF files.
   
  JmolVersion=\"14.28.4\" // released 2018.01.25
   
  bug fix: script \"minimize; calculate partialcharge\" can cause exception
   
  bug fix: partial charges not reset to 0 after atom type change as with
  {\_N}\[2\].element = \"O\"
   
  bug fix: isosurface CACHE should store isosurface as byte\[\] not String
  otherwise it is not saved in a subsequent WRITE xxx.PNG AS PNGJ
   
   
  JmolVersion=\"14.28.3\" // released 2018.01.19
   
  bug fix: mmtf broken - needs \"/v1.0/\"
  bug fix: BCIF/CIF volume reader not properly assigning axes in some cases
  bug fix: GAMESS reader does not work with symmetry indicated in input deck
   
  JmolVersion=\"14.28.2\" // released 2018.01.17
   
  new feature: isosurface eds
  \- generates electron density surface 2fo-fc for current PDB model
  \- trimmed to structure
  \- note that isosurface eds AS \"t.bcif\" will save the full data block to a BCIF file
   
  new feature: isosurface within 3 {e20:A} eds
  \- generates electron density surface 2fo-fc for current PDB model
  \- localized to WITHIN specification
  \- note that adding AS \"t.bcif\" will save only the retrieved localized block to a BCIF file
   
  new feature: isosurface edsdiff
  \- generates electron density surface fo-fc for current PDB model
  \- trimmed to structure
   
  new feature: isosurface \"=1eve/full\"
  \- generates electron density surface 2fo-fc for 1eve
  \- reads and shows full data set, not trimmed to structure
   
  new feature: isosurface \"=1eve/diff\"
  \- generates electron density surface fo-fc for 1eve
   
  new feature: isosurface \"=1eve/diff/full\"
  \- generates electron density surface fo-fc for 1eve
  \- reads and shows full data set, not trimmed to structure
   
  bug fix: for BCIF/CIF EBI density server data, switch to sigma_sampled from sigma_source
   
  JmolVersion=\"14.28.1\" // released 2018.01.14
   
  new feature: WRITE CONTACT xxx.jvxl
  \- saves a JVXL file for a contact
  \- reload using ISOSURFACE xxx.jvxl, not CONTACT
   
  new feature: write contact \"cache://t.jvxl\"
  \- saves a contact as a jvxl file in the cache
   
  new feature: isosurface \"cache://t.jvxl\"
  \- loads an isosurface from a cached JVXL file
   
  new feature: generalized use of cache://
  \- cache:// saves or retrieves files from the FileManager cache
  \- cleared upon ZAP
  \- for example, the following transfers a contact to an isosurface for saving to a PNGJ file
   
  load =1eve
  zoom {e20:a} 0
  contact {e20:A} hbond
  write contact cache://t.jvxl
  isosurface cache://t.jvxl
  contact delete
  write t3.png as PNGJ
   
   
  new feature: isosurface reads EBI density server files (BinaryCIF and CIF)
  \-- for example:
  isosurface \"https://www.ebi.ac.uk/pdbe/densities/x-ray/1eve/box/-3.434,55.646996,59.195/7.479,70.943,74.928?space=cartesian&encoding=bcif\"
  isosurface \"https://www.ebi.ac.uk/pdbe/densities/x-ray/1eve/box/-3.434,55.646996,59.195/7.479,70.943,74.928?space=cartesian&encoding=cif\"
   
  new feature: Jmol automatically uses EBI density server BinaryCIF files when \"within\" keyword is used.
  \-- for example:
   
  load =1eve
  display e20
  zoom {displayed} 0
  isosurface within 4 {e20:A} \"=1eve\"
   
  \-- allows testing of non-binary CIF electron density files using .cif:
   
  isosurface within 4 {e20:A} \"=1eve.cif\"
   
  bug fix: loading, modifying, and resaving a PNGJ file fails in Java
  bug fix: JavaScript JSmol improperly saves a PNGJ file within a PNGJ file
   
  JmolVersion=\"14.27.2\"
   
  new feature: frame MO
  \- goes to first frame with a molecular orbital
   
  bug fix: \[UNK\] missing in atom identities, even when part of actual structures such as 3A0B
   
  bug fix: polyhedra ID p1 \@11 to {connected(\@11)} not working
  \-- allows for \$p1.getProperty(\....)
   
  bug fix: load(filename, \"JSON\") should allow for files that start with \"\[\" rather than \"{\"
   
  bug fix: JSJSON parser fails for leading whitespace in map values
   
  code: additions to QCJSONWriter and QCJSONReader
  \- working with Jmol-datafiles/qcjson/preliminary
  \- \"QCJSON 0-0-0.Jmol_14.27.2\_\_2017-12-11_09:38\",
   
  JmolVersion=\"14.27.1\" released 2017.12.11
   
  new feature: functions write(\"zip\") and write(\"jmol\")
  \- allows creating a binary variable containing zip data
  \- does not include preview.png (unlike write xxx.zip or xxx.jmol)
  \- includes any local files (as for WRITE command)
  \- \"zip\" does not include remote-access files
  \- \"jmol\" DOES include remote-access files
  \- allows use of .pop() and .push() to remove, modify, or add files
  \- same as write xxx.zip; x = load(\"xxx.zip\",true) \-- except includes no preview.png
   
  \- for example:
   
  load \$caffeine
  x = write(\"jmol\")
  x.push(\"mydata\",\"testing\")
  write var x \"test.zip\"
  y = load(\"test.zip\", true)
  print y.keys
  \...
  print y.mydata
   
  testing
   
  load test.zip
  \...
   
  load \$caffeine
  x = write(\"jmol\")
  zap
  load var x
   
   
  bug fix: CIPChirality adds \"mancude system\" averaging of atomic numbers in Rule 1a
   
  JmolVersion=\"14.26.1\"
   
  new feature: experimental qcjson write format - ALPHA only
   
  bug fix: decimal formatter failing for 9.9999999 to 5 digits
  bug fix: Jaguar reader not reading MOs; (working, but still does not read STO-3G)
   
  bug fix: direct call to sun.audio on some systems fails;
  \-- moved to class openscience.jmol.jmolPanel.JmolAudio
  \-- accessed by reflection, so not loaded unless needed.
   
  code - synchronized with NBOServe project. (2017.11.10)
   
  JmolVersion=\"14.25.2\"
   
  bug fix: DCD (trajectory) reader failing when periodic lattice info is present
   
  JmolVersion=\"14.25.1\"
   
  \>\> TODO NEEDS DOCUMENTING:
   
  new feature: polyhedra WIGNER // Wigner-Seitz cell
  new feature: polyhedra BRILLOUIN // 1st Brillouin zone
  new feature: polyhedra BRILLOUIN 1 // 1st Brillouin zone
  new feature: polyhedra BRILLOUIN 2 // 2nd Brillouin zone
  new feature: polyhedra BRILLOUIN -1 // Wigner-Seitz cell
  new feature: polyhedra scale 3.0 BRILLOUIN 1 // scaled 1st Brillouin zone
   
  bug fix: MOL file reader should not autobond if number of bonds is 0.
   
  JmolVersion=\"14.24.2\" // 2017.11.08
   
  bug fix: invertSelected was not clearing chirality
  bug fix: JmolAppletSigned0.jar fails \-- missing org/apache/tools
  bug fix: SHOW SMILES sometimes missing allene chirality
  bug fix: hbondsDistanceMaximum should not be limited by 2.5 max; increased maximum to 3.5
  bug fix: hbondsDistanceMaximum and hbondsAngleMinimum should not be in state
   
  code: moved scriptEval.cmdInvertSelected to scriptext.cmdExt
   
  JmolVersion=\"14.24.1\" // 2017.11.05
   
  new feature: MACRO bz; createWS(\"p1\")
  \-- creates a Wigner-Seitz cell as polygon id \"p1\"
  \-- requires current unit cell to be primitive to work correctly
  \-- polyhedron can be shifted using POLYHEDRA OFFSET
  \-- default ID \"pbz1_1\_\" for just CREATEWS()
   
   
  new feature POLYHEDRA edgesOnly
  \-- shows just edges
  \-- operates on ALL polyhedra
  \-- complements edges, noEdges, frontEdges
   
  new feature: select within(d, \$p1) where \$p1 is a polyhedron ID
  \-- d = 0 is \"on or within the polyhedron\"
  \-- d \< 0 is \"-d angstroms within polyhedron\"
  \-- d \> 0 is \"within d angstroms of polyhedron\"
   
  bug fix: POLYHEDRA edges should inherit color, not use black as default
   
  bug fix: calculate CHIRALITY may fail to show Z for some seqCis systems
   
  new macros:
   
  \"aflow\", \"http://aflowlib.mems.duke.edu/users/jmolers/jmol/spt/AFLOW.spt\", \"AFLOW macros\",
  \"bz\", \"http://aflowlib.mems.duke.edu/users/jmolers/jmol/spt/bz.spt\", \"Brillouin Zone/Wigner-Seitz macros\"
   
   
  code: biomodel classes are being loaded prematurely due to \@cystine definition involving cys.sg instead of cys and atomname=sg
   
  JmolVersion=\"14.23.1\" // 2017.11.02
   
  new feature: load \"\" fill UNITCELL PRIMITIVE (for files that are conventional)
  new feature: load \"\" fill UNITCELL CONVENTIONAL (for VASP files, which are primitive cells)
   
  bug fix: primitive unit cell incorrect for rhombohedral lattice space groups
  (trigonal R\...; 146, 148, 155, 160, 161, 166, 167)
  bug fix: (AFLOW specific) CIF for trigonal and hexagonal cells (itn 143-194) should orient rotated 60 deg cw
  bug fix: LOAD \... SUPERCELL {2 2 2} broken
   
  JmolVersion=\"14.22.2\"
   
  bug fix: PubChem partial charges are only to 0.01 precision, so a test in dipole creation of
  balanced charges must allow for more than that \-- changed to 0.015. Case in point: :PF3.
   
  JmolVersion=\"14.22.1\" // 2017.10.28
   
  new feature: draw BOUNDBOX BEST
  \-- draws the best box around currently selected atoms
   
  bug fix: a.distance.min(b).min should not report 0 if a == b. (testing atom against itself should be skipped)
  bug fix: SHOW BEST ROTATION just shows the current rotation, not the best rotation to use to get to the best view
  bug fix: rotate BEST can fail with flat structures
  bug fix: LOAD \"\" FILE BOUNDBOX does not include all atoms
   
  JmolVersion=\"14.21.1\" // 2017.10.22
   
  new feature: set noDelay true sets all time delays to 0 and forces all file operations to be synchronous
   
  bug fix: CIP adds S4 symmetry check in Rule 6
  bug fix: chirality broken for JavaScript in MSIE 11 due to range error
  bug fix: Should be able to save PNGJ from menu even if zapped (because there might be a surface)
   
  JmolVersion=\"14.20.9\"
   
  bug fix: JavaScript does not handle saving PNGJ from modified PNGJ
  bug fix: JavaScript command SHOW NMR broken
   
  JmolVersion=\"14.20.8\" // 2017.10.07
   
  bug fix: STEREO DTI never implemented for Java, only JavaScript
  bug fix: color property_xxxx broken
  bug fix: platformSpeed not actuated for wheel zoom.
   
  JmolVersion=\"14.20.7\"
   
  bug fix: calculate chirality broken for JSmol (missing Integer.compare)
   
  JmolVersion=\"14.20.6\"
   
  bug fix: MO HOMO + n delivers HOMO + 2\*n
  code: more efficient CIPChirality using breadth-first scanning for chirality descriptors
   
  JmolVersion=\"14.20.5\" // 2017.08.29
   
  bug fix: isosurface intersect unitcell broken
  bug fix: show spacegroup does not report H-M name
   
  JmolVersion=\"14.20.4\" // 2017.08.09
   
  bug fix: SpartanSMOL reader for iSpartan files does not read charges or vibrational mode data
  bug fix: CIPChirality fix for BH64_075; adding Rule 3b.
  bug fix: CIPChirality new Rule 6 covers all special spiro cases and C3-symmetry
  bug fix: SMILES generator fails for \[2H\]/C=C/\[1H\]
  bug fix: write SDF fails for 1H. (Must use M ISO.)
   
  JmolVersion=\"14.20.3\" // 2017.07.20
   
  bug fix: ROTATE should not stop spin if it does not initiate a spin
  bug fix: CIPChirality tests for CIP1966\#31,\#32 douple spirans and C3 compounds
  bug fix: CIPChirality for Rule 2 using atomic masses and not for duplicate atoms
  bug fix: MOL file reading where isotope is indicated in atom line and V item
  bug fix: MOL reader fails for H1, D, T isotopes indicated as symbols along with isotope difference
   
   
  JmolVersion=\"14.20.2\" // 2017.07.09
   
  bug fix: CIPChirality adding presort for Rules 4a and 4c (test12.mol; 828 lines)
  bug fix: write SDF and write MOL do not set atom parity field
  bug fix: JavaScript JSmol broken for chirality due to bug in Clazz.clone(obj)
   
  bug fix: Upgrade of natural abundance average masses (no significant changes here):
   
  // all numbers except radionuclides from:
  // Atomic weights of the elements 2013 (IUPAC Technical Report)
   
   
  // Thomas Prohaska Published Online: 2016-02-24 \| DOI: https://doi.org/10.1515/pac-2015-0305
  // https://www.degruyter.com/view/j/pac.2016.88.issue-3/pac-2015-0305/pac-2015-0305.xml
   
  /\* 1 H \*/ 1.008f, 4.002f,
  /\* 2 Li \*/ 6.9675f, 9.012f, 10.8135f, 12.0106f, 14.006f, 15.999f, 18.998f, 20.1797f,
  /\* 3 Na \*/ 22.989f, 24.307f, 26.981f, 28.084f, 30.973f, 32.059f, 35.4515f, 39.948f,
  /\* 4 K \*/ 39.0983f, 40.078f, 44.955f, 47.867f, 50.9415f, 51.9961f, 54.938f, 55.845f, 58.933f, 58.6934f, 63.546f, 65.38f, 69.723f, 72.63f, 74.921f, 78.971f, 79.904f, 83.798f,
  /\* 5 Rb \*/ 85.4678f, 87.62f, 88.905f, 91.224f, 92.906f, 95.95f, 98.91f, 101.07f, 102.905f, 106.42f, 107.8682f, 112.414f, 114.818f, 118.71f, 121.76f, 127.6f, 126.904f, 131.293f,
  /\* 6 Cs, Ba, actinides \*/132.905f, 137.327f, 138.905f, 140.116f, 140.907f, 144.242f, 144.9f, 150.36f, 151.964f, 157.25f, 158.925f, 162.5f, 164.93f, 167.259f, 168.934f, 173.054f, 174.9668f,
  /\* 6 Hf \*/ 178.49f,180.947f,183.84f,186.207f,190.23f,192.217f,195.084f,196.966f,200.592f,204.3835f,207.2f,208.98f,210f, 210f, 222f,
  /\* 7 Fr, Ra, lanthanides \*/ 223f, 226.03f, 227.03f, 232.0377f, 231.035f, 238.028f, 237.05f, 239.1f, 243.1f, 247.1f, 247.1f, 252.1f, 252.1f, 257.1f, 256.1f, 259.1f, 260.1f,
  /\* 7 Rf - Mt \*/ 261f, 262f, 263f, 262f, 265f, 268f
   
   
  JmolVersion=\"14.20.1\" // 2017.07.06
   
  new feature: BZ2 compressed file reader
  \-- uses org.apache.tools.bzip2.CBZip2InputStream v. 1.9.6
  \-- Apache license
   
  bug fix: ADF reader not accepting Xx.name atom ids
   
  bug fix: SMILES generator can show wrong @/@@ or stereochemical type for some allenes and cumulenes
  bug fix: CIPChirality additional Rules 1b, 4b, and 4c fixes (substituted cubanes; multiple branched branches; 841 lines)
   
  JmolVersion=\"14.19.1\" // 2017.06.25
   
  new feature: WRITE \"SDF\" implements atom value V nnn \... information
  \-- requires assigning the data property name \"atom_values\" in the model\'s molData property
  \-- for example:
   
  \$ load \$2,3-dichlorobutane
  \$ molData = {\"atom_values\":\"chirality\"}
  \$ model properties \"molData\" molData
  \$ write dcb.sdf
   
  \-- note that if the model already has a molData property, then use the following to append to it:
   
  \$ molData = (\_M.molData ? \_M.molData : {})
  \$ molData.atom_values = \"chirality\"
  \$ model properties \"molData\" molData
   
  new feature: x = load(\"filename\",\"JSON\")
  \-- loads JSON data into variable
   
  bug fix: CIPChirality: minor fixes for Rule 4b and 5 for BH64_012-015; better atropisomer check
  bug fix; SPIN QUATERNION
  bug fix: CENTERAT ABSOLUTE broken (since forever?)
  bug fix: SPIN QUATERNION {0 0 -1 0} still does a positive, not negative, rotation
  (solution is to apply a miniscule rotation of 1e-10 degrees)
   
  bug fix: script array context \[3 -0\] becomes \[3\], as in \[3 - 0\]
   
  bug fix: SET ANTIALIASDISPLAY requires click \[via resizeImage()\]
  bug fix: CIP gives wrong alkene root distance for cyclopropene
  bug fix: WRITE of structure file does not report number of atoms and warn if selected is different from this molecule
  bug fix: WRITE MOL using format 10f.5 instead of 10f.4 for x, y, z coordinates
  bug fix: MOL/SDF files should truncate lines at 80 characters.
   
  JmolVersion=\"14.18.1\" // 2017.06.06
   
  bug fix: CIP misses Rule 4b cases where a branching atom has R or S chirality.
  \-- see test_bt_P4.mol and test_bt_O3.mol (BH64.65 and BH64.66)
  \-- see AY236.179 (3D structure was diasteriomer, so I missed that)
   
  bug fix: WRITE MOL should not generate \> \<JMOL_PARTIAL_CHARGES\> because it is not SDF format
  bug fix: WRITE SDF should generate \> \<JMOL_PARTIAL_CHARGES\> with a trailing space
   
  bug fix: (SMILES) targetString.find(\"SMILES\",patternString) will fail for .\[C\@H\]2 (new group and attached to a connection number)
  bug fix: SHOW CHEMICAL SMILES fails when logLevel is set \> 4
   
  new feature: WRITE SDF writes \> \<\.... user data
  \-- can be set using MODEL PROPERTY \"molData\" x where x is an associative array
  \-- can be read using \_M.molData
   
  new feature: associativeArray.pop() \-- clears associativeArray
  new feature: assArray1.push(assArray2) \-- adds all key/value entries in assArray2 to assArray1.
  new feature: assArray1 + assArray2 \-- adds all key/value entries into a new associative array. (Complements a1 - a2)
   
   
  JmolVersion=\"14.17.2\" // 2017.06.03
   
  bug fix: WRITE FILE not working when file has been cached.
  bug fix: array.find(\"regex\...\",\"\") does not reset RegExp each time it runs RegExp.exec() so does not find all possibilities
   
  code: CIPChirality.java fully interfaced using SimpleNode and SimpleEdge
   
  JmolVersion=\"14.17.1\" // 2017.05.27
   
  new feature: atom property x.cipRule
  \-- CIP sequence rule deciding this center
  \-- one of 1a, 1b, 2, 3, 4a, 4b, 4c, 5, or blank
   
  bug fix: polyhedra broken in Jmol 14.10.0
   
  bug fix: finalizing CIP algorithm
  \-- adding spiro chirality from P-93.5.3
  \-- completing root path for auxiliary descriptors
   
  bug fix: JSmol: JSME/JSmol 2D-\>3D fails when one H of a CH2 is explicitly wedge and the other H is implicit (not shown at all). (JSmolJME.js)
   
  code:
   
  /\*\*
  \* A full validated relatively efficient implementation of Cahn-Ingold-Prelog
  \* rules for assigning R/S, M/P, and E/Z stereochemical descriptors. Based on
  \* IUPAC Blue Book rules of 2013.
  \* https://iupac.org/projects/project-details/?project_nr=2001-043-1-800
  \*
  \* Features include:
  \*
  \* - deeply validated
  \*
  \* - implemented in Java (Jmol) and JavaScript (JSmol)
  \*
  \* - only two Java classes; roughly 1000 lines
  \*
  \* - efficient, one-pass process for each center using a single finite digraph for all auxiliary descriptors
  \*
  \* - exhaustive processing of all 8 sequence rules (1a, 1b, 2, 3, 4a, 4b, 4c, 5)
  \*
  \* - includes R/S, r/s, M/P (axial, not planar), E/Z
  \*
  \* - covers any-length odd and even cumulenes
  \*
  \* - uses Jmol conformational SMARTS to detect atropisomers and helicenes
  \*
  \* - covers chiral phosphorus and sulfur, including trigonal pyramidal and tetrahedral
  \*
  \* - properly treats complex combinations of R/S, M/P, and seqCis/seqTrans centers (Rule 4b)
  \*
  \* - properly treats neutral-species resonance structures using fractional atomic mass and a modified Rule 1b
  \*
  \* - implements CIP spiro rule (BB P-93.5.3.1)
  \*
  \* - detects small rings (fewer than 8 members) and removes E/Z specifications for such
  \*
  \* - detects chiral bridgehead nitrogens
  \*
  \* - reports atom descriptor along with the rule that ultimately decided it
  \*
  \* Primary 236-compound Chapter-9 validation set (AY-236) provided by Andres
  \* Yerin, ACD/Labs (Moscow).
  \*
  \* Mikko Vainio also supplied a 64-compound testing suite (MV-64), which is
  \* available on SourceForge in the Jmol-datafiles directory.
  \* (https://sourceforge.net/p/jmol/code/HEAD/tree/trunk/Jmol-datafiles/cip).
  \*
  \* Additional test structures provided by John Mayfield.
  \*
  \* Additional thanks to the IUPAC Blue Book Revision project, specifically
  \* Karl-Heinz Hellwich for alerting me to the errata page for the 2013 IUPAC
  \* specs (http://www.chem.qmul.ac.uk/iupac/bibliog/BBerrors.html), Gerry Moss
  \* for discussions, Andres Yerin for discussion and digraph checking.
  \*
  \* Many thanks to the members of the BlueObelisk-Discuss group, particularly
  \* Mikko Vainio, John Mayfield (aka John May), Wolf Ihlenfeldt, and Egon Willighagen, for
  \* encouragement, examples, serious skepticism, and extremely helpful advice.
  \*
   
   
  JmolVersion=\"14.16.1\" // 2017.05.19
   
  new feature: load =chebi/nnnnnn
  \-- chEBI 2D molecule load, with minimal 100-step minimization
  \--
   
  bug fix: CML reader does not read 2D wedge/hash information
   
  bug fix: CIP fix for missing branch descriptors; 984 lines
   
  bug fix: CIP adds helicene M/P chirality
  \- validated using CCDC structures HEXHEL02 HEXHEL03 HEXHEL04 ODAGOS ODAHAF
  \- http://pubs.rsc.org/en/content/articlehtml/2017/CP/C6CP07552E
   
  code: CIP: additional simplification;
  code: CIP status: implementation complete, including:
  All subrules implemented fully: 1a, 1b, 2, 3, 4a, 4b, 4c, 5
  R/S, E/Z, M/P (odd-cumulene and helicene), r/s, seqCis/seqTrans (as Z/E)
  fused benzenoid aromatic Mancude ring \"Kekule weighted\" atom number adjustments
   
  \* Added logic to Rule 1b: The root distance for a Kekule-ambiguous duplicate
  \* atom is its own sphere, not the sphere of its duplicated atom.
  \*
  \* Stated more precisely:
  \*
  \* Proposed amended Sequence Rule 1:
  \*
  \* (1a) higher atomic number precedes lower;
  \*
  \* (1b) in comparing two duplicate nodes, lower root distance precedes higher
  \* root distance, where \"root distance\" is defined:
  \*
  \* (i) in the case of a duplicate atom for which the atomic number is averaged
  \* over two or more atoms in applying Rule 1a, the distance from the duplicate
  \* node itself to the root node; and
  \*
  \* (ii) in all other cases, the distance of its corresponding nonduplicated atom
  \* node to the root node.
  \*
   
  JmolVersion=\"14.15.4\" // 2017-05-13
   
  bug fix: INVERTSELECTED ATOM not documented; functionality of INVERTSTEREO SELECTED folded into it, and INVERTSELECTED STEREO deprecated
  \-- inverts ring or chain stereochemistry
  \-- adds that keyword ATOM is optional, so INVERTSELECTED \@2 works
   
  bug fix: \@n for \"atom n\" not working in several script-checking contexts where {atoms} works.
   
  bug fix: CIP full implementation; simplified algorithm - 984 lines
  bug fix: CIP Rule 1b modification to ensure aromatic rings do not result in false positive for R/S (binap2)
  \-- specifically that the duplicate atom is given a root distance equal to its sphere, not that of its duplicated atom
  bug fix: CIP chiral bridgehead N designations missing
  bug fix: CIP Assignment of auxiliary r/s not functional (AY-236.201,202)
  bug fix: CIP basic \"mancude\" atom number adjustment for heteroatoms
  \-- implemented for benzenoids (benzene, pyridine, pyrazine) and fused benzenoids only
   
  new feature: set debugHigh
  \-- same as set loglevel 6 - debugging only
  \-- debugging only; not considered significant enough to increment minor version
   
  JmolVersion=\"14.15.3\" // 2017-05-08
   
  bug fix: SMARTS search for atropisomeric bond that is in an alicyclic ring fails (Fred Ziegler)
  \- used for M/P chirality check
  \- for example:
  load \$c1cc2c3-c4c5CC2.c5ccc4C.c3(C)c1
  select on smarts(\"a-a\")
  calculate chirality
  print {\*}.chirality.join(\"\")
   
  MM
   
  bug fix: use of the less preferred name of Jmol token that has two optional
  forms (\"fix\" vs \"fixed\") as a VAR does not assign that variable name
  bug fix: set cartoonRibose misses the C1\'-O4\' and O3\'-P(+1) edges
  bug fix: JVXL reader not reading Gaussian files with \"1\" in the third line, 5th field
  bug fix: CIP M/P chirality
  test: load \"\$2,2\'-dibromobiphenyl\"; calculate chirality; print {\*}.chirality.join(\"\")
  bug fix: CIP chirality nearly fully validated on ACD/Labs AY-236 set, with some unimplemented aspects:
   
  var skip = ({27 229}) \|\| // E/Z only; missing chirality
  ({95 96 98 99 100 101 102 103 104 108 109 110 111 112 200}) \|\| // trigonal planar, square planar, or hypervalent
  ({32 33}) \|\| // helicene // added in Jmol 14.15.5
  ({201 202})\|\| // spirocyclic central (redundant) atom designation missing (axial designation option)
  ({212 213})\|\| // chiral conformation 1,4-benzene in a ring
  ({38 84}) \|\| // ignore \-- 38: Mancude for cyclopentadienyl; 84: unknown error with P compound
  ({203}) \|\| // // chiral bridgehead amine // fixed in Jmol 14.15.5
   
  Issue: Full implementation of the rules requires a slight modification of Rule 1b.
  Specifically, aromatic duplicate atoms must reference the sphere of their own parent, not their
  duplicated atom.
   
  Three structures appear to be in error in the IUPAC Blue Book 2013.
   
  ,\"147\":\"r,,,R,,,,r,,,S\" // r,,,R,,,,r,,,R chiral phosphine \-- I think Jmol is right; disagrees with BB P-93.5.1.1.2 for S vs R
  ,\"227\":\"SrSEErS\" // S,,,,,,,r,S,,,,,,,E,,r,r // \-- I think Jmol is right; disagrees with BB P-93.5.7.2 for S vs. r
  ,\"230\":\"\@2D RrRsR\" // r,,,R,,,,s,,,R // p 1282 \-- I believe Jmol is correct, disagrees with BB P-93.6
   
  One structure awaiting full implementation of Rule 4b across all chirality types, R/S, M/P, and seqCis/seqTrans
   
  ,\"170\":\"Spp\" // Jmol is missing the S \-- mix of R/S and M/P for Rule 4b
   
  \- 939 lines
   
  JmolVersion=\"14.15.2\" // 4/29/17
   
  bug fix: CIP chirality adds axial chirality (M/P\[Ra/Sa\], m/p\[ra/sa\]) for cumulenes
  bug fix: CIP chirality adds atropisomer chirality (M/P\[Ra/Sa\], m/p\[ra/sa\]) for biaryls
  bug fix: CIP chirality adds cumulene E/Z chirality
  \-- 816 lines
  \-- validation data are at https://sourceforge.net/p/jmol/code/HEAD/tree/trunk/Jmol-datafiles/cip/
  \-- validates for 160 structures (some duplicates; both cip_examples.zip and stereo_test_cases.sdf)
  \-- validates for all cases considered:
  \-- simple R/S and E/Z
  \-- small-ring removal of E/Z
  \-- parallel-strand Rule 4b and Rule 5 (Mata)
  \-- pseudochiral r/s and m/p
  \-- odd and even cumulenes
  \-- atropisomers
  \-- P, S, As, Se, Sb, Te, Bi, Po trigonal pyramidal and tetrahedral
  \-- imine and diazine E/Z chirality
   
  JmolVersion=\"14.15.1\" // 4/28/17
   
  new feature: x.split(true)
  \-- does a white-space token split of the string value of x
   
  new feature: MOL/SDF reader reads M ISO lines for isotopes
   
  bug fix: CIP chirality adds P, S, As, Se, Sb, Te, Bi, Po trigonal pyramidal and tetrahedral
  bug fix: CIP chirality adds imine and diazine E/Z chirality
  bug fix: CIP chirality broken for carbonyl groups
  bug fix: CIP chirality E/Z should not be indicated for rings of size \< 8
   
  bug fix: values not saved in state for cartoonBlockHeight, cartoonBlocks, and cartoonSteps
  bug fix: write MO broken
  bug fix: set cartoonBlockHeight (for DSSR nucleic acid rendering) fails
   
  code: CIPChirality.java 779 lines Rules 1-5 validated on 145 compounds
  \- see https://sourceforge.net/p/jmol/code/HEAD/tree/trunk/Jmol-datafiles/cip/
  code: CIP optimizations
   
  JmolVersion=\"14.14.1\" // 4/19/17
   
  new feature: CALCULATE CHIRALITY {atom set}
  \-- starts with basic CIP Rule 1-2 determination of R/S and E/Z.
  \-- continues with Rules 3-5, which require full-molecule analysis.
  \-- work in progress:
  \-- Rules 1 and 2 complete
  \-- Rule 3 (E/Z) implemented
  \-- Rule 4 partially implemented
  \-- simple linear sequences of R/S ok
  \-- Rule 5 implemented
  \-- caveates
  \-- no pseudochirality
  \-- not cyclitols
  \-- does not distinguish rings, so inserts \"Z\" into ring bonds
  \-- only validated on
   
  \-- optionally limited to the given atom set (or the currently selected atoms by default)
   
  new feature: set jmolInJSpecView
  \-- allows Jmol window to NOT be embedded in JSpecView when JSpecView is opened in Jmol
  \-- default TRUE
   
  new feature: WRITE ISOSURFACE \"t.pmesh\"; WRITE ISOSURFACE \"t.pmb\"
  \-- creates ASCII (.pmesh) or binary (.pmb) file (a Jmol-specific file format)
  \-- relatively compact format
  \-- can speed up loading of meshes and contours
  \-- for filled surfaces, use .jvxl instead
  \-- read back into Jmol using ISOSURFACE \"t.pmesh\"/\"t.pmb\"
  \-- note that binary files are NOT RECOMMENDED for JSmol because some platforms cannot read them locally
  \-- example:
   
  load \$methane
  isosurface plane {0 0 0 1} map vdw contours 20
  write ISOSURFACE contour.pmb
  isosurface contour.pmb
   
   
  bug fix: mesh capper producing gaps
  bug fix: CIP chirality fixed for rule ordering; validated for IUPAC Rules 1, 2, and 3 (though still some questions about Rule 3)
  bug fix: print getProperty(\"cifinfo\") without file name fails
   
   
  JmolVersion=\"14.13.1\" // 2017.04.09
   
  new feature: MOL V2000 reader loads \> \<dataname\> blocks into \_M.molData
   
  new feature: set labelfor {atomset} \"value\"
  \-- allows setting of label without changing current selection
  \-- uses same syntax as LABEL command after {atomset}
  \-- for example:
   
  set labelfor \@atoms \@myLabel
  set labelfor {atomno \<= 3} @{\[\"a\",\"b\",\"c\"\]}
  set labelfor {\_C && chirality != \"\"} \"%\[atomname\] %\[chirality\]\"
   
  bug fix: {\*}.chirality with triple bonds fails
  bug fix: {\*}.chirality fix for duplicate atoms check
   
  bug fix: dotted line has extra dot: measure ID m \@1 \@4 radius 0.1
  bug fix: NBO H-BOND and MODEL focus issues
   
   
  JmolVersion=\"14.12.1\"
   
  bug fix: NBO update
  bug fix: JavaScript bug - missing Math.signum(f) - causes {atom}.chirality to not work in JSmol
   
  JmolVersion=\"14.12.0\" // 2017-04-06
   
  new feature: {atom}.chirality
  \-- uses Cahn-Ingold-Prelog rules to assign R or S to a carbon center
  \-- ignores sulfur chirality
  \-- may not fully implement high symmetry cases
  \-- not fully tested
  \-- Checked using:
   
  function checkchiral(m) {
  if (m) load \@m
  background label yellow
  color labels black
  select \_C
  label %\[atomname\]
  refresh
  var b = {\_C}
  for (var a in b) {
  var c = a.chirality;
  print \_smilesString + \" \" + a + c
  if (c) {
  select a
  c = a.atomname + \" \" + c
  label \@c
  }
  }
  select \*
  }
   
  checkchiral(\"\$(R)-glycidol\")
  delay 1
  checkchiral(\"\$glucose\")
  delay 1
  checkchiral(\"\$(2S,3R)-2,3-oxiranediol\")
  delay 1
  checkchiral(\"\$(S)-2-butanol\")
  delay 1
  checkchiral(\"\$(R)-2-butanol\")
  delay 1
  checkchiral(\"\$(2S,3R)-2,3-butanediol\")
  delay 1
  checkchiral(\"\$(2S,3S)-2,3-butanediol\")
  delay 1
  checkchiral(\"\$(2R,3R)-2,3-butanediol\")
  delay 1
  checkchiral(\"\$(2R,3S)-2,3-butanediol\")
  delay 1
  checkchiral(\"\$1,4-dimethylcyclohexane\")
  delay 1
  checkchiral(\"\$cholesterol\") // (3S,8S,9S,10R,13R,14S,17R) and sidechain R
   
   
  JmolVersion=\"14.11.3\" // 2017-04-06
   
  bug fix: partial bond order for orders \> 3 not working
  \-- for example: connect {\_C} {\_C} partial 5.3
  bug fix: NBO MODEL loading with no file name goes to wrong directory
  bug fix: NBO job names need to be cleaned and set if necessary
  bug fix: some sort of bad build for DSSR
   
  JmolVersion=\"14.11.2\" // 2017-04-04
   
  bug fix: NBO fixes
  bug fix: backboneSteps moved to cartoonSteps
  // order of checking for TRUE is:
  // cartoonBlocks, cartoonBaseEdges, cartoonSteps, cartoonLadders, cartoonRibose
   
  JmolVersion=\"14.11.1\" // 2017-04-03
   
  bug fix: set cartoonBlocks; set cartoonBlockHeight x.x
  \-- needs to be cartoon, not backbone (needs to be single-monomer based)
  \-- replaces set backboneBlocks; set backboneBlockHeight x.x from 14.11.0
  \-- for nucleic only
  \-- overrides set cartoonSteps and cartoonBaseEdges
  \-- uses DSSR data if present (using calculate structure DSSR or load =xxxx/dssr)
  \-- displays a DSSR block for each base based on dssr.nts.frame
  \-- x.x is height of box in Angstroms (default 0.5)
   
  bug fix: NBO communications upgrade - still has bug in NPA atom charge query
   
  JmolVersion=\"14.11.0\" // released 4/1/2017
   
  new feature: color NUCLEIC
  \-- for nucleic only (others will be grey)
  \-- based on DSSR nucleic color scheme:
  G green, C yellow, A red, T blue, U cyan
   
  new feature: set backboneBlocks; set backboneBlockHeight x.x
  \-- but see bug fix above
  \-- for nucleic only
  \-- overrides set backboneSteps
  \-- uses DSSR data if present (using calculate structure DSSR or load =xxxx/dssr)
  \-- displays a DSSR block for each base based on dssr.nts.frame
  \-- x.x is height of box in Angstroms (default 0.5)
   
  new feature: color property DSSR type
  \-- where type is one of:
  bulges
  coaxStacks
  hairpins
  hbonds
  helicies
  iloops
  isoCanonPairs
  junctions
  kissingLoops
  multiplets
  nonStack
  nts
  pairs
  ssSegments
  stacks
  stems
  \-- color is based on index into the list of the given structures
  \-- 0 (not of that structure), 1 (first entry), 2 (second entry), etc.
  \-- for example:
   
  load =4fe5/dssr
  backbone -0.5;set backboneSteps;
  color property dssr junctions
  color {color=red} grey // just making \"not this type\" grey instead of red
   
  \[ most bases are grey, but one region is green and one region is blue \]
   
   
  bug fix: drag-drop of PDB file with isolated nucleic acids gives odd unbonded look
  bug fix: set drawPicking TRUE does not report pending measurement
  bug fix: DSSR calculation should reset after atom coordinate changes
  bug fix: using Jmol.scriptWait() within a callback will not work, as it will overwrite the currently running eval object
   
   
  JmolVersion=\"14.10.0\" // released 3/25/2017
   
  new feature: x = {\*}.find(smartsString,\"map\")
  \-- returns an array of arrays of atom indices (0-based)
  \-- indicates exact correlation between atoms in {\*} and atoms of smartsString
  \-- only unique sets of atoms are found, not every possibility
  \-- for example:
   
  load \$caffeine
  print {\*}.find(\"\*1\*\*\*\*\*1\", \"map\").format(\"JSON\")
   
  \[ \[ 0,2,4,6,11,12 \] \]
   
  new feature: SELECT \@x where x is an array of integers or array of array of integers
  \-- selects atoms from array rather than from a bitset
  \-- note that variable must be used, as SELECT \[1,2,3\] would look for PDB group \"1,2,3\"
  \-- for example:
   
  load \$caffeine
  x = {\*}.find(\"\*1\*\*\*\*\*1\", \"map\")\[0\]
  select \@x
   
  6 atoms selected
   
  new feature: DRAW polygon \@face \@points
  \-- draws a filled polygon based on arrays of atom indices
  \-- \@face is an array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
  \-- for example:
   
  load \$p4
  x = {\*}.find(\"\*1\*\*1\",\"map\");
  draw ID p4r polygon @{x\[1\]} color red
  draw ID p4b polygon @{x\[2\]} color blue
  draw ID p4y polygon @{x\[3\]} color yellow
  draw ID p4g polygon @{x\[4\]} color green
   
   
  new feature: DRAW polyhedron \@faces \@points
  \-- draws sets of polygons based on arrays of atom indices
  \-- \@faces is an array of array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
  \-- for example:
   
  load \$caffeine
  draw polyhedron @{{\*}.find(\"\*1\*\*\*\*1\|\|\*1\*\*\*\*\*1\",\"map\")}
   
  load \$p4
  draw ID p polyhedron @{{\*}.find(\"\*1\*\*1\",\"map\")} color red
   
  new feature: POLYHEDRON ID xxx \@faces \@points
  \-- \@faces is an array of array of integers, not necessarily wound correctly
  \-- \@points is an atom bitset or an array of points (optional, defaults to {\*}
   
  load \$p4
  polyhedra ID p4 @{{\*}.find(\"\*1\*\*1\",\"map\")}
   
  new feature: 4-order bond in MOL file using 14 for bond order
  \-- Jmol extension for MOL file format to allow 4-bond
  \-- example: \[Re2Cl8\](2-)
  \-- see https://en.wikipedia.org/wiki/Quadruple_bond
   
  new feature: 5-order bond in MOL file using 15 for bond order
  \-- Jmol extension for MOL file format to allow 5-bond
  \-- example: \[Mo2Cl8\](4-)
  \-- see https://en.wikipedia.org/wiki/Quintuple_bond
   
  new feature: 6-order bond in MOL file using 16 for bond order
  \-- Jmol extension for MOL file format to allow 6-bond
  \-- example: Mo2
  \-- see https://en.wikipedia.org/wiki/Sextuple_bond
   
  new feature: load \"=xxxx/dssr\--xxx=yyy\"
  \-- allows adding specialized options to dssr
  \-- \--xxx=yyy added on to &opt= search item
   
  bug fix: DSSR fix for multi-model PDB file
  bug fix: DSSR - 4fe5 HPA ligand causes set backboneSteps true to fail
  bug fix: EXIT command with -n command line flag does not exit Jmol
  bug fix: echo renderer may not show correct font size
  bug fix: POLYHEDRA ID id OFFSET {x y z} broken
  bug fix: ScriptManager debug output being sent even if -i (silent) command line option set.
   
  JmolVersion=\"14.9.1\" released 2/19/2017
   
   
  bug fix: bad release file for 14.9.0
   
  JmolVersion=\"14.9.0\"
   
  new feature: connect NBO \<nbotype\>
  \- connect atoms in the currently visible model using a resonance structure configuration found in an NBO .46 or .nbo file
  \- where \<nbotype\> is one of alpha\|beta\|46\|46a\|46b\|nrtstr_n\|nrtstra_n\|rs_n\|rsa_n\|rsb_n
   
  new feature: label %\[nbo\];
  \- label an atom using a resonance structure configuration found in an NBO .46 or .nbo file
  \- requires a previous connect NBO
   
  new feature: set nboCharges (default true)
  \- determines whether formal charges are also displayed with LABEL %\[nbo\]
   
  new feature: quintuple and sextuple bonds.
  \-- connect \@1 \@2 quintuple
  \-- connect \@1 \@2 sextuple
  \-- readily saved in state
  \-- adding MOL file bond type 15 and 16 for these \-- a bit of a hack, of course.
   
  new feature: Viewer.runScriptCautiously(String) replacement name for older Viewer.runScript(String)
   
  new feature: plugin main menu item.
  \- allows integrated additions to Jmol
  \- Just has NBO at this time; could have more, as it is a simple interface.
  \- created automatically from reading org/openscience/jmol/app/plugins/plugin.properties,
  which just contains a list of name=class pairs:
   
  \# plugin.properties
   
  NBO=org.gennbo.NBOPlugin
   
  new feature: startup options -U nbo or \--plugin nbo
  \- starts Jmol in NBO mode, as if the Plugins\...NBO menu item had been clicked
  \- could be generalized, but do not that more than just nbo in place at this time
  \- case insensitive
   
  new feature: NBO n BETA - for GenNBOReader nth beta orbital; could be expanded
   
  bug fix: SHOW CHEMICAL JME (from NCI CIR) does not properly return formal charges
   
  bug fix: JSpecView, when open in application, does not allow ZAP
   
  bug fix: draw POINTGROUP crashes Jmol if model is not first model
   
  bug fix: DRAW circle rendering broken (load \$2-butene ; draw pointGroup)
   
  bug fix: NBO/ISOSURFACE command - Displaying BETA orbitals for NBO types (NHO, PNBO, etc.) that
  are from a file other than the current file causes read failure and no orbital display.
   
  bug fix: Viewer.runScript(String) now uses evaluateExpression(T\[\])
   
  Lesson learned: Never mix viewer.runScript() and viewer.runScriptQueued() calls.
  What will happen is that the unqueued calls will corrupt the
  queued calls. However, if you use viewer.evaluateExpression(\"script(\'\....\')\"),
  that is also synchronous, and it uses a new ScriptEval() to isolate it from
  the script being queued. You still have the problem that the scripts could
  mess up each other, but at least it will not cause catastrophic failure.
   
   
  bug fix: \*.CA should pick up calcium in a PDB file
   
  bug fix: cfi format (for NBOPro) writing broken
  \- from using the command
   
  x = data({\*}, \'cfi\')
   
  bug fix: La and Ac should be in transitionmetal
   
  bug fix: GenNBO reader not recognizing FILTER \"BETA\"
   
  code: NBO options extended using the NBO VIEW or NBO OPTIONS \"\...\" command options
   
  protected boolean jmolOptionNOZAP = false; // do no zap between modules
  protected boolean jmolOptionNOSET = false; // do not use NBO settings by default
  protected boolean jmolOptionVIEW = false; // present only the VIEW option
  protected boolean jmolOptionNONBO = false; // do not try to contact NBOServe
   
  noting previously undocumented:
   
  set fontscaling true; font label 10 arial plain 0.020
   
  \- last number is a fontscaling factor that allows one to set a font size for
  \- labels in angstroms. Roughly, this pointSize \* factor is in Angstroms.
  \- if label is changed, one must use set fontscaling FALSE; label \.... ; fontScaling TRUE;
   
   
  JmolVersion=\"14.8.1\"
   
  bug fix: isosurface color \"user\" as an equivalent to isosurface colorscheme \"user\" broken
  bug fix: color isosurface range 1 122 ignores preset isosurface color scheme and just uses the default color scheme
   
   
  JmolVersion=\"14.8.0\"
   
  JmolVersion=\"14.8.0-beta-2016-12-17\"
   
  Release Note: switching to semantic versioning (http://semver.org/)
  Release Note: When releasing beta version, append \"-beta-YYYYMMDD\"
   
  Release Note: new features listed are since first release of 14.5.4 (2016.04.30)
   
  new feature: set echo OFFSET {sx sy sz}
  \-- sets the echo offset to a specific screen Angstrom offset
   
  new feature: set echo OFFSET \[mode sx sy sz ax ay az\] never implemented
  \-- see set labelOffset
   
  new feature: set labelOffset \[mode sx sy sz ax ay az\] (3.1.15, never documented)
   
  set labelOffset \[sx, sy, sz\]
  set labelOffset \[mode, sx, sy, sz, ax, ay, az\]
   
  where
   
  sx,sy,sz are screen coord offsets
  \-- applied after view rotation
  \-- sy \> 0 LOWERS label
  ax,ay,az are xyz position (in Angstroms; applied before view rotation)
  mode == 0 indicates xyz position is absolute and sx sy sz are Angstroms
  mode == 1 indicates xyz position is relative to atom position and sx sy sz are Angstroms
  mode == 2 indicates xyz is absolute, and sx sy sz positions are screen pixels
  mode == 3 indicates xyz is relative, and sx sy sz positions are screen pixels
  defaults: mode == 1; ax = ay = az = 0
   
  new feature: fully implemented CIF 2.0 reader
   
  new feature: MagCIF reader upgraded to new IUCr standard
  \-- first CIF 2.0 format implemented by IUCr
  \-- see http://comcifs.github.io/magCIF.dic.html
   
  new feature: x = getProperty(\"cifInfo\", \"c:/temp/test.cif\")
  \-- reads CIF file data in structured format
  \-- automatically uses CIF 1.0 or CIF 2.0, as needed.
  \-- if file name is missing, uses current model file
   
  new feature: autocalculation of MMFF94 partial charges
  \-- isosurface \... map MEP
  \-- DIPOLE MOLECULAR
  \-- no need to preface these with CALCULATE PARTIALCHARGE
   
  new feature: 3DPrinter-compatible VRML and STL writing.
  \-- mesh only; does not use high-level objects Cone, Cylinder, Sphere
  \-- extensive use of dEF and USE for small-footprint VMRL files
  \-- STL is binary generally, but will be ASCII using SET DEBUG TRUE
  \-- write t.wrl
  \-- write t.stl
   
  new feature: measure ID \"test\" radius 0.0 font 15.0 SansSerif Plain align CENTER \@1 \@2 \"test\"
  \-- radius 0.0 turns off line (optional)
  \-- font\... sets font (optional)
  \-- align \[left\|right\|center\|none\] sets text alignment (optional)
  \-- requires ID
   
  new feature: allowance for external app loading of binary (mmtf) files
  or any other file using a simple interface:
  Viewer.openReader(fullPathName, reader)
   
  new feature: Jmol reads PyMOL 1.8 PSE files with \"set dump_binary, 1\"
   
  new feature: load AUDIO audiofilename
  \-- Java and JavaScript applet can read WAV, MP3, and OGG files
  \-- application can read WAV files\]
   
  new feature: settable chain string using {atomset}.chain = \"xxx\"
   
  new feature: set hiddenLinesDashed
  \-- when set TRUE, hidden lines in unit cells and boundbox are rendered as dashed lines.
  \-- default is FALSE
   
  new feature: polyhedron -x.x \....
  \-- sets maximum radius for gap calculation to be x.x
   
  new feature: \$pbz1_1\_.getProperty(x) where x is \"info\",
  \"faces\", \"faceTriangles\", \"faceCount\",
  \"face_areas\", \"face_types\", \"face_points\",
  \"vertices\", \...more\...
  \-- polyhedra informationoru
   
  new feature: unitcell(\"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\")
  \- array of center and three vectors
  \- example:
  \$ print unitcell(\"a=10,b=10,c=20,alpha=90,beta=90,gamma=129\")
  {0.0 0.0 0.0}
  {10.0 0.0 0.0}
  {-6.293203 7.7714605 0.0}
  {-8.742278E-7 -1.8328565E-6 20.0}
   
  new feature: load \... unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
   
  new feature: unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
  \-- only the numbers are read; everything else is ignored, so order is important here
  \-- uses the format created by show unitcell/a
   
  new feature: unitcell RECIPROCAL 2
  \-- as integer, multiples of pi
   
   
  new feature: polyhedra AUTO \...
  \-- sets polyhedron radius automatically, using \"MAXIMUM GAP\" rule
   
   
  http://www.degruyter.com/view/j/zkri.1971.133.issue-1-6/zkri.1971.133.16.127/zkri.1971.133.16.127.xml?rskey=sfBNTx&result=1
   
  new feature: unitcell reciprocal x.x
  \-- allows scaling of reciprocal cell, similar to unitcell(\"reciprocal\", x.x)
   
  new feature: write CIF
  \-- just a very simple CIF file, P1 format
  \-- allows writing a simple CIF file with changed coordinates after a UNITCELL command
   
  new feature: full implementation of OpenSMILES and OpenSMARTS in Jmol
  see http://opensmiles.org and http://www.moldb.net/opensmarts
   
  new feature: C13 NMR prediction from http://www.nmrdb.org/service/jsmol13c?smiles=CCCC
  \-- although we send MOL file, not SMILES here.
  \-- actuated with
   
  SHOW NMR H1 // H1 1H H or just SHOW NMR all default to this
  SHOW NMR C13 // or C or 13C
  SHOW NMR none // close JSpecView
   
  new feature: Jmol now implements a way of indicating atropisomer chirality.
  \-- measured dihedral angle is clockwise-positive front-to-back, as for Jmol dihedrals
  \-- matching with {\*}.find(\"SMILES\",\"\...a\^nm-a\...\") where n and m are 1, 2, or 3
  indicate first, second, or third, respectively, and indicate which bonds of
  the biaryl bond, as written, are to the reference atoms.
  \-- for example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ print {\*}.find(\"SMARTS\",\"c1(O)ccccc1\^23-c2c(O)cccc2\")
   
  ({0:13})
   
  Explained below.
   
  new feature: CONNECT {pair1} {pair2} ATROPISOMER
  \-- creates a new bond of type atropisomer (bond chirality in biaryl systems)
  \-- each pair must include the bonded atom and its reference connected atom
  \-- example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ getProperty bondinfo\[7\].type
   
  bondinfo\[7\].type \"atropisomer_23\"
   
  new feature: BONDORDER ATROPISOMER_nm
  \-- not for general use; will be found in state file
  \-- for example:
   
  select BONDS ({6});
  bondOrder atropisomer_23;
   
  new feature: Jmol SMILES bond atropisomerism \^nm- and \^\^nm-
  \-- indicates atropisomerism (bond chirality in biaryl systems)
  \-- \^ and \^\^ for bonds similar to @ and and @@ for atoms
  \-- n and m are single-digit bond selectors, generally one of 1, 2, or 3
  \-- n = 1/2/3 means \"reference atom is first/second/third bonded
  \-- \^- and \^\^- same as \^22- and \^\^22-, respectively
  \-- example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ print {\*}.find(\"SMARTS\",\"c1(O)cccc{c1\^23-c2}c(O)cccc2\")
   
  ({1 6})
   
  Here the \"\^23-\" refers to the two carbons with connected oxygen atoms, because the second
  bond listed for the carbon on the left is to the c1(O) atom, and the third bond listed for
  the carbon on the right is to the other c(O) atom. Note that bond numbering includes the
  implicit bond to the atom coming from the atom on its left, which for the second carbon,
  starts with the atropisomeric bond itself, at least in this case.
   
  1\*23 1\*23
  c1(O)ccccc1\^23-c2c(O)cccc2
   
   
  JmolVersion=\"14.7.5_2016.12.17\"
   
  bug fix: incorrect referencing of pt.fxyz and pt.xyz when unit cells have offsets
   
  JmolVersion=\"14.7.5_2016.12.06\"
   
  bug fix: DSSR final touches
   
  \-- see https://chemapps.stolaf.edu/jmol/docs/misc/JmolSQLforDSSR.pdf
   
  After loading a file from the PDB with the /dssr attribute:
   
  LOAD =1ehz/dssr
   
  The associative array \_M.dssr holds the DSSR information. This array has the following main keys and subkeys of interest to this discussion:
   
  bulges
  coaxStacks
  coaxStacks.stems
  hairpins
  hbonds
  helicies
  helicies.pairs
  iloops
  isoCanonPairs
  junctions
  kissingLoops
  kissingLoops.hairpins
  multiplets
  nonStack
  nts
  pairs
  ssSegments
  stacks
  stems
  stems.pairs
   
  Each key or subkey is itself an array of associative arrays. For example,
   
  LOAD =1ehz/dssr
  PRINT \_M.dssr.stems.length
  PRINT \_M.dssr.stems\[1\].pairs.length
  PRINT \_M.dssr.stems\[1\].pairs\[1\]
  PRINT \_M.dssr.pairs.select(\"where name=\'Imino\'\")
  PRINT \_M.dssr.pairs.select(\"where name != \'WC\'\").count
  PRINT \_M.dssr.coaxStacks\[1\].stems.select(\"where strand1=\'GACAC\' or strand2=\'GACAC\'\")\[1\].pairs.count
  x = \"GACAC\"
  PRINT \_M.dssr.coaxStacks\[1\].stems.select(\"where strand1=x or strand2=x\")\[1\].pairs.count
  SELECT \"\|1\|A\|A\|44\|\|\|\|\"
  SELECT @{\_M.dssr.pairs.select(\"where name != \'WC\'\")}
  SELECT ON within(dssr, \"nts\")
  SELECT ON within(dssr, \"nts\[WHERE v0\>17 and v1 \<-39\]\")
  SELECT ON within(dssr, \"nts.2\")
  SELECT ON within(dssr, \"nts\[WHERE v0\>1 and v1 \<0\].2\")
   
  JmolVersion=\"14.7.5_2016.12.02\"
   
  new feature: fully implemented CIF 2.0 reader
   
  new feature: x = getProperty(\"cifInfo\", \"c:/temp/test.cif\")
  \-- reads CIF file data in structured format
  \-- automatically uses CIF 1.0 or CIF 2.0, as needed.
  \-- if file name is missing, uses current model file
   
  JmolVersion=\"14.7.4_2016.11.28\"
   
  new feature: MagCIF reader upgraded to new IUCR standard
  \-- see http://comcifs.github.io/magCIF.dic.html
  \-- only required these two key changes:
   
  // old: \_magnetic_space_group.transform_from_parent_Pp_abc
  // new: \_parent_space_group.child_transform_Pp_abc
   
  // old: \_magnetic_space_group.transform_to_standard_Pp_abc
  // new: \_space_group_magn.transform_BNS_Pp_abc
   
  JmolVersion=\"14.7.4_2016.11.22\"
   
  new feature: adds MagCIF reader based on http://comcifs.github.io/magCIF.dic.html
  new feature: adds CIF array \[\...\] reading (as a string only; reader needs to parse this)
   
  JmolVersion=\"14.7.4_2016.11.05\"
   
  bug fix: miscalculates vector scale and direction for incommensurate modulation of magnetic spin
  bug fix: MoleculeInfo.nElements incremented by number of elements on each subsequent call rather
  rather than being properly reset to zero before recalculating.
   
  JmolVersion=\"14.7.4_2016.11.02\"
   
  bug fix: load x.cif {1 1 1} (where that file has no unitcell) throws a loading error
   
  JmolVersion=\"14.7.4_2016.10.26\"
   
  bug fix: POV-Ray output spheres too large \-- somehow broken in 14.6.4_2016.10.15
   
  JmolVersion=\"14.7.4_2016.10.23\"
   
  code: netscape.jar references isolated to org.jmol.applet.Jmol
   
  JmolVersion=\"14.7.4_2016.10.21\"
   
  bug fix: menu item for X3D export delivers STL; item for STL not functional
  bug fix: X3D export includes extraneous VRML text
  bug fix: load \"\@x\" not saved in state properly
  bug fix: IDTF exporter broken in Jmol 14.7.4_2016.10.02
   
  JmolVersion=\"14.7.4_2016.10.15\"
   
  bug fix: (JSmolJavaExt.js) JSmol/HTML5 WRITE xxx.stl not working.
  bug fix: STL export can place two endcaps in the same location
   
  JmolVersion=\"14.7.4_2016.10.09\"
   
  new feature: autocalculation of MMFF94 partial charges
  \-- isosurface \... map MEP
  \-- DIPOLE MOLECULAR
  \-- no need to preface these with CALCULATE PARTIALCHARGE
   
  bug fix: MOL and V3000 readers should add implicit partial charges of 0 when only some partial charges are given
   
  bug fix: fine lines or dots rendered around boxes in ROCKETS
   
  bug fix: SET MEASUREMENTS x.x is 10x too wide
   
  bug fix: MO command does not allow SQUARED with PLANE
  bug fix: MO command SQUARED does not reset cutoff to its square
  bug fix: MO command does not preserve SQUARED after PLANE command
   
  bug fix: MOLDEN reader does not accept \[MOLDEN FORMAT\]
   
  bug fix: WRL/X3D/STL surface closure for rockets, cartoons, polyhedra, ellipsoids, geosurface, draw
  bug fix: triangle renderer miscalculates z-index, causing some hidden triangle bits to show
   
  code: refactoring of line rastering improves efficiency
   
  JmolVersion=\"14.7.4_2016.10.02\"
   
  new feature: 3DPrinter-compatible VRML and STL writing.
  \-- mesh only; does not use high-level objects Cone, Cylinder, Sphere
  \-- extensive use of dEF and USE for small-footprint VMRL files
  \-- STL is binary generally, but will be ASCII using SET DEBUG TRUE
  \-- write t.wrl
  \-- write t.stl
   
  JmolVersion=\"14.7.3_2016.09.29\"
   
  bug fix: COD CIF files have mixed-lower case atom labels (H5a) in bonds def, causing Jmol to miss bonds.
  bug fix: rogue System.out.println for text rendering.
   
  JmolVersion=\"14.7.3_2016.09.21\"
   
  bug fix: print compare({1.1}, {2.1}, \"MAP\", \"H\") broken in 14.6.0_2016.06.14
   
  JmolVersion=\"14.7.3_2016.09.18\" released
   
  new feature: show chemical formula reads formula from CIF
   
  bug fix: write MENU broken for non-English language (UTF-8 strings not correctly encoded using base64)
  bug fix: write PNGJ should not store \"\#\_DOCACHE\_\" in PNGJ file
  bug fix: JSmol echo image loading from PNGJ can fail
  bug fix: load \"\" after pasting in structure to load fails
   
  JmolVersion=\"14.7.2_2016.09.12\"
   
  new feature: measure ID \"test\" radius 0.0 font 15.0 SansSerif Plain align CENTER \@1 \@2 \"test\"
  \-- radius 0.0 turns off line (optional)
  \-- font\... sets font (optional)
  \-- align \[left\|right\|center\|none\] sets text alignment (optional)
  \-- requires ID
   
  JmolVersion=\"14.7.2_2016.09.01\"
   
  bug fix: show vdw USER broken
  bug fix: COMPARE {1.1} {2.1} SMILES should be ignoring stereochemistry
  bug fix: CIF subsystem reader broken
   
  JmolVersion=\"14.7.2_2016.08.30\"
   
  bug fix: SMILES comparison of two strings will report incorrect stereochemistry
   
  JmolVersion=\"14.7.2_2016.08.29\"
   
  bug fix: load FILES does not deliver \_modelFileName for individual models
  bug fix: NCI/CADD reader not escaping \"\\\" in SMILES (javajs.util.PT.escapeUrl)\"
   
  JmolVersion=\"14.6.2_2016.08.28\"
  syncronized and released as 14.6.2_2016.08.28
   
  new feature: allowance for external app loading of binary (mmtf) files
  or any other file using a simple interface:
  Viewer.openReader(fullPathName, reader)
   
  bug fix: RCSB -\> https \"https://files.rcsb.org/download/%FILE.pdb\"
   
  bug fix: EBI sites to https
  bug fix: Spartan 16 reader may have empty first model
  bug fix: 2D model show SMILES uses \@SP \-- should be /nostereo/ based on \_.dimension == \"2D\"
  bug fix: NCI/CADD now requires \"get3d=true\" not \"get3d=True\"
   
  code: Unit test includes binary types PyMOL and MMTF
   
  JmolVersion=\"14.7.1_2016.08.20\"
   
  feature change: updated links to EBI electron density maps (formerly Uppsala; for isosurface \"\*xxxx\")
   
  \"pdbemap\", \"http://www.ebi.ac.uk/pdbe/coordinates/files/%file.ccp4\",
  \"pdbemapdiff\", \"http://www.ebi.ac.uk/pdbe/coordinates/files/%file_diff.ccp4\"
   
  code: recoding in javajs.util.Measure.calculateQuaternionRotation (Andrew Hanson)
   
  JmolVersion=\"14.7.1_2016.08.11\"
   
  bug fix: PyMOL dump_binary file reading fixes
   
  JmolVersion=\"14.7.1_2016.08.09\"
  sycnronized with Jmol 14.6.1
  bug fix: upgrade of RCSB mmtf format reading to version 0.2 specs
   
  load =2tbv.mmtf {1 1 1} filter \"biomolecule 1;\*.ca\"
   
   
  JmolVersion=\"14.7.1_2016.08.08\"
   
  new feature: Jmol reads PyMOL 1.8 PSE files with \"set dump_binary, 1\"
   
  JmolVersion=\"14.7.1_2016.07.29\"
   
  bug fix: COMPARE command can fail if an atom has no bonds
   
  JmolVersion=\"14.7.1_2016.07.24\"
   
  bug fix: write x.pdb for multimodel file does not work.
   
  JmolVersion=\"14.7.1_2016.07.11\"
   
  sychronized with Jmol 14.6
   
  bug fix: Jmol SMILES not allowing for insertion-code search
  \-- adds \"\^\" for insertion code: \[G\#129\^A.\*\]
   
   
  JmolVersion=\"14.7.0_2016.07.06\"
   
  bug fix: Jmol can crash on point group calculation for small polyhedra
   
  JmolVersion=\"14.7.0_2016.06.30\"
   
  bug fix: cartoon rendering broken in 2016.06.28
   
  JmolVersion=\"14.7.0_2016.06.28\"
   
  bug fix: using an exporter (write VRML, eg) with cartoonsFancy will break rendering after that
  bug fix: after loading PNGJ data, using write FILE crashes Jmol
   
  JmolVersion=\"14.7.0_2016.06.27\"
   
  new feature: load AUDIO audiofilename
  \-- Java and JavaScript applet can read WAV, MP3, and OGG files
  \-- application can read WAV files\]
   
   
  \<\<\< above is not documented TODO
   
   
  JmolVersion=\"14.7.0_2016.06.23\"
   
  bug fix: nn.? and nn.\* are not processed properly as float nn.
  For example: print (35 == 35.? \"yes\" : \"no\") cause script exception
   
  JmolVersion=\"14.7.0_2016.06.22\"
   
  new feature: settable chain string using {atomset}.chain = \"xxx\"
   
  bug fix: compare(a,b,\"isomer\") does not detect ENANTIOMER (broken in 14.5.5)
  bug fix: missing error trap for unsettable property setting
  bug fix: load models {0 0 1} \... fails in script compiler
   
  JmolVersion=\"14.7.0_2016.06.21\"
   
  bug fix: x3d export shows partial bond as standard bond
   
  JmolVersion=\"14.7.0_2016.06.14\"
   
  bug fix: reading of protein structure for a group that is not in a polymer causes null pointer exception
   
  new feature: set hiddenLinesDashed
  \-- when set TRUE, hidden lines in unit cells and boundbox are rendered as dashed lines.
  \-- default is FALSE
   
  JmolVersion=\"14.7.0_2016.05.27\"
   
  new feature: polyhedron -x.x \....
  \-- sets maximum radius for gap calculation to be x.x
   
  JmolVersion=\"14.7.0_2016.05.26\"
   
  bug fix: set hermiteLevel -4 allows hermite during mouse move but not spinning
  bug fix: QchemReader not
   
  JmolVersion=\"14.7.0_2016.05.25\"
   
  bug fix: polyhedron faces not generated correctly when postions are very close together (still)
  bug fix: polyhedron face areas not calculated correctly
   
  new feature: \$pbz1_1\_.getProperty(x) where x is \"info\",
  \"faces\", \"faceTriangles\", \"faceCount\",
  \"face_areas\", \"face_types\", \"face_points\",
  \"vertices\", \...more\...
  \-- polyhedra information
   
  new feature: print unitcell(\"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\")
  new feature: load \... unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
  new feature: unitcell \"a=\...,b=\...,c=\...,alpha=\...,beta=\...,gamma=\....\"
  \-- only the numbers are read; everything else is ignored, so order is important here
  \-- uses the format created by show unitcell/a
   
  new feature: unitcell RECIPROCAL 2
  \-- as integer, multiples of pi
   
  JmolVersion=\"14.7.0_2016.05.24\"
   
  bug fix: localization broken due to too-old GNU msgfmt version.
  bug fix: splash image not appearing in Jmol application Help\...about Jmol
  bug fix: Jmol application Help may not appear at all
  bug fix: switching out of hermite \"fancy\" cartoons doesn\'t actually do that.
   
   
  code: removing unnecessary J/api/JmolBioMeshRenderer.js
  \-- when I started working with Java2Script, I thought that
  all references to a class had to be removed and an interface used instead
  if modularization was to work in JavaScript. But it turns out only \"new Xxx()\"
  will trigger that request. This might be something I changed in j2sjmol.js early
  on; I cannot remember.
   
  new feature: polyhedra AUTO \...
  \-- sets polyhedron radius automatically, using \"MAXIMUM GAP\" rule
   
   
  http://www.degruyter.com/view/j/zkri.1971.133.issue-1-6/zkri.1971.133.16.127/zkri.1971.133.16.127.xml?rskey=sfBNTx&result=1
   
  JmolVersion=\"14.7.0_2016.05.23\"
   
  new feature: unitcell reciprocal x.x
  \-- allows scaling of reciprocal cell, similar to unitcell(\"reciprocal\", x.x)
   
  new feature: write CIF
  \-- just a very simple CIF file, P1 format
  \-- allows writing a simple CIF file with changed coordinates after a UNITCELL command
   
  bug fix: calculate pointgroup polyhedra \"xxx\" does not work
  bug fix: draw pointgroup \$xxx does not work for named polyhedra
  bug fix: named polyhedra set visibility broken
  bug fix: colors light(and dark)grey and light(and dark)gray should be synonymous
  bug fix: isosurface SILENT should pass that to readers
   
  popup menu: reorganization of color\... submenu
   
  JmolVersion=\"14.7.0_2016.05.17\"
   
  new feature: full implementation of OpenSMILES and OpenSMARTS in Jmol
  see http://opensmiles.org and http://www.moldb.net/opensmarts
   
  code: unnecessary org.jmol.util.BNode removed; methods now part of org.jmol.util.Node
   
  new feature: C13 NMR prediction from http://www.nmrdb.org/service/jsmol13c?smiles=CCCC
  \-- although we send MOL file, not SMILES here.
  \-- actuated with
   
  SHOW NMR H1 // H1 1H H or just SHOW NMR all default to this
  SHOW NMR C13 // or C or 13C
  SHOW NMR none // close JSpecView
   
  new feature: Jmol now implements a way of indicating atropisomer chirality.
  \-- measured dihedral angle is clockwise-positive front-to-back, as for Jmol dihedrals
  \-- matching with {\*}.find(\"SMILES\",\"\...a\^nm-a\...\") where n and m are 1, 2, or 3
  indicate first, second, or third, respectively, and indicate which bonds of
  the biaryl bond, as written, are to the reference atoms.
  \-- for example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ print {\*}.find(\"SMARTS\",\"c1(O)ccccc1\^23-c2c(O)cccc2\")
   
  ({0:13})
   
  Explained below.
   
  new feature: CONNECT {pair1} {pair2} ATROPISOMER
  \-- creates a new bond of type atropisomer (bond chirality in biaryl systems)
  \-- each pair must include the bonded atom and its reference connected atom
  \-- example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ getProperty bondinfo\[7\].type
   
  bondinfo\[7\].type \"atropisomer_23\"
   
  new feature: BONDORDER ATROPISOMER_nm
  \-- not for general use; will be found in state file
  \-- for example:
   
  select BONDS ({6});
  bondOrder atropisomer_23;
   
  new feature: Jmol SMILES bond atropisomerism \^nm- and \^\^nm-
  \-- indicates atropisomerism (bond chirality in biaryl systems)
  \-- \^ and \^\^ for bonds similar to @ and and @@ for atoms
  \-- n and m are single-digit bond selectors, generally one of 1, 2, or 3
  \-- n = 1/2/3 means \"reference atom is first/second/third bonded
  \-- \^- and \^\^- same as \^22- and \^\^22-, respectively
  \-- example:
   
  \$ load \$biphenol
  \$ connect @{\@7\|\@8} @{\@1\|\@2} atropisomer
  \$ print {\*}.find(\"SMARTS\",\"c1(O)cccc{c1\^23-c2}c(O)cccc2\")
   
  ({1 6})
   
  Here the \"\^23-\" refers to the two carbons with connected oxygen atoms, because the second
  bond listed for the carbon on the left is to the c1(O) atom, and the third bond listed for
  the carbon on the right is to the other c(O) atom. Note that bond numbering includes the
  implicit bond to the atom coming from the atom on its left, which for the second carbon,
  starts with the atropisomeric bond itself, at least in this case.
   
  1\*23 1\*23
  c1(O)ccccc1\^23-c2c(O)cccc2
   
  \<\<\< above is not documented TODO
   
   
  bug fix: MolPRO reader broken
   
  bug fix: Jmol SMILES directive /noaromatic/ should ignore \":\" bond type
  bug fix: Jmol SMILES directive /aromaticDouble/ not implemented for SMILES
  buf fix; Jmol SMARTS measurements should be required to come after branches
  bug fix: Jmol SMILES parser should require connection numbers to be placed prior to branches
  bug fix: Jmol SMILES should not allow (.t!50,60,70,80)
  bug fix: Jmol SMILES should treat search(\"\[THR.\*\]\[THR.\*\]\") should select all atoms in each group
  bug fix: Jmol SMILES should return ({}) not ERROR if no atoms are involved
   
  code: StateCreator and Shape getStateInfo methods simplified and condensed
   
  JmolVersion=\"14.5.4_2016.04.30\"
   
  new feature: 13C Simulated spectra (but without correlation yet)
   
  bug fix: bondorder command broken in 14.1.8_2014.02.17
  bug fix: polyhedra COLLAPSED option in conjunction with UNITCELL breaks rendering
  bug fix: \"axis\" keyword dropped from vocabulary, disabling MOVETO AXIS\...
   
  JmolVersion=\"14.5.4_2016.04.25\"
   
  new feature: (JavaScript) Jmol.loadFileFromDialog(jmolApplet0)
  \-- asynchronous file loading on demand
  \-- can be model file, but can also be script, dssr data - anything
  \-- can be a local file or a URL
  \-- see dssr.htm
  \-- for example:
   
  Jmol.jmolButton(\"jmolApplet0\", \[function(){Jmol.loadFileFromDialog(jmolApplet0)}\],\"Open File\")
   
  new feature: setting DSSR on the fly:
   
  model 1 property dssr \"1d66.dssr\" // file containing data
  model 1 property dssr @{load(\"1d66.dssr\")} // actual data
  select iloops
   
  \<\<\< above is not documented TODO
   
   
  bug fix: show spaceGroup can crash after load \... filter \"biomolecule 1\"
   
  bug fix: load =1auy.cif {1 1 1} does not complete atoms in unit cell
  for files with noncrystallographic symmetry operations (\_struct_ncs\...) such as viral capsids
   
  bug fix: load =1auy.cif {1 1 1} filter \"BIOMOLECULE 1;\*.ca\" does not work
   
  code: =xxxx/DSSR path changed to http://dssr-jmol.x3dna.org from http://x3dna.bio.columbia.edu/dssr
   
   
  JmolVersion=\"14.5.4_2016.04.24\"
   
  new feature: show chemical xxx where xxx is one of the file types:
   
  alc cdxml cerius charmm cif cml ctx gjf gromacs hyperchem jme
  maestro mol mol2 sybyl2 mrv pdb sdf sdf3000 sln smiles xyz
   
  retrieves this information for the currently selected set of atoms
  from the the NCI CACTVS Resolver.
   
  Note that the PDB writer is nonstandard, and \"SDF\" no longer returns
  the 2D mol file, only the 3D mol file.
   
  Can be used as the show() function: x = show(\"chemical jme\")
   
  \<\<\< above is not documented TODO
   
   
  new feature: print {\*}.find(\"SMILES/hydrogen/\") adds hydrogen atoms
   
  \<\<\< above is not documented TODO
   
   
  feature note: JSME upgraded to JSME_2015-12-06-2
   
  bug fix: NCI switch to using /sdf for 3D rather than 2D, breaks jsv_predict2.html
  \-- requires converting mrv format to jme:
   
  function getJMEHs() {
  var x= show(\"chemical mrv\")
  var x2 = x.split(\'x2=\"\')\[2\].split(\'\"\')\[1\].split(\' \')
  var y2 = x.split(\'y2=\"\')\[2\].split(\'\"\')\[1\].split(\' \')
  var el = x.split(\'elementType=\"\')\[2\].split(\'\"\')\[1\].split(\' \')
  var s = \'\' + {\*}.size + \' \' + {\*}.bonds.size + \' \' + el.join(x2).join(y2).join(\' \').replace(\'\\n\',\' \')
  var b = x.split(\"\<bond \")
  for (var i = 2; i \<= b.length; i++) {
  var bi = b\[i\]
  var at = bi.split(\'atomRefs2=\"\')\[2\].split(\'\"\')\[1\].replace(\'a\',\'\')
  var n = (bi.find(\'\>W\<\') ? -1 : bi.find(\'\>H\<\') ? -2 : bi.split(\'order=\"\')\[2\].split(\'\"\')\[1\])
  s += \' \' + at + \' \' + n
  }
  return s
  }
  load \$morphine
  x = getJMEHs()
  print x
   
   
  bug fix: show VARIABLES broken
  bug fix: after load =xxxx/dssr, selection \"naChains\" is defined, but it is not an atom list
  bug fix: hyperchem reader may not interpret aromatic correctly
  bug fix: show chemical \... will not use the correct structure if it came from NCI and has been changed via modelKitMode.
   
  code: JmolBioModelSet and BioModel untangled
  code: JmolBioModelSet moved to org.jmol.modelsetbio.BioModelSet
  code: JmolBioModelSet changed from interface to class
  code: unnecessary JmolBioResolver interface removed
   
  JmolVersion=\"14.5.4_2016.04.23\"
   
  FEATURE CHANGE: Jmol 14.5.4_2016.04.23 by default will implement DSSP 2.0 as described in
  Int. J. Mol. Sci. 2014, 15, 7841-7864; doi:10.3390/ijms15057841
  and implemented at http://www.cmbi.ru.nl/dssp.html.
  This change only affects helices that have bulges, indicating them
  more appropriately as pi helices rather than alpha helices.
   
  The original version of DSSP, \"DSSP 1.0\" will be available using
   
  calculate structure DSSP 1.0
  show DSSP 1.0
  load \... filter \"DSSP1\"
   
  This change is for 14.5 only, not 14.4, which remains DSSP 1.0
   
  code: unnecessary org.jmol.modelset.JmolBioModel interface removed
  code: unnecessary org.jmol.api.DSSPInterface removed
  code: DSSP 1.0/2.0 switch in ModelLoader only necessary while 14.4 and 14.5 are being compiled in parallel
   
  JmolVersion=\"14.5.4_2016.04.22\"
   
  bug fix: on loading, crystallographic file reading fails when applying symmetry
  bug fix: on loading, user-defined space groups using Hall symbol fails
  bug fix: SHELX reader broken
   
   
  JmolVersion=\"14.5.4_2016.04.21\"
   
  bug fix: CIF files with missing tags that Jmol needs fail to load at all.
  (Not necessarily a bad thing, but it is not supposed to fail so dramatically.)
  bug fix: mmCIF/mmTF reader does not complete symmetry for biomolecules when there is a lattice.
  for example:
   
  load =2tbv.mmtf {1 1 1} filter \"biomolecule 1;\*.ca\"
  backbone off; spacefill 200%
  color property symop
   
  bug fix: mmCIF, PDB, and mmTF readers with lattice indicated does not show unit cell
   
  JmolVersion=\"14.5.4_2016.04.19\"
   
  new feature: preliminary MMTF reader
  \-- MacroMolecular Transmission Format (MMTF, from RTSB)
  \-- see https://github.com/rcsb/mmtf/blob/master/spec.md\#overview
  \-- binary format for file transfer and molecule construction
  \-- uses MessagePack binary JSON format
  \-- entirely experimental; not for general consumption
  \-- biomolecule processing works
  \-- DSSP secondary structure is read
   
  \*
  \* JmolData RCSB MMTF (macromolecular transmission format) file reader
  \*
  \* see https://github.com/rcsb/mmtf/blob/master/spec.md
  \*
  \* /full/ specification as of 2016.4.18 is implemented,including:
  \*
  \* reading atoms, bonds, and DSSR secondary structure
  \*
  \* load =1f88.mmtf
  \*
  \*
  \* reading space groups and unit cells, and using those as per other readers
  \*
  \* load =1crn.mmtf {1 1 1}
  \*
  \* reading bioassemblies (biomolecules) and applying those transformations
  \*
  \* load =1auy.mmtf FILTER \"biomolecule 1;\*.CA,\*.P\"
  \*
  \* reading biomolecules and lattices, and loading course-grained
  \*
  \* load =1auy.mmtf {2 2 1} filter \"biomolecule 1;bychain\";spacefill 30.0; color property symop
  \*
  \*
   
  bug fix: certain viral capsid CIF files will fail to load due to this line: XAU \'(X0)(1-10,21-25)\' A,B,C
  bug fix: DSSR selection includes too many atoms
  bug fix: PSE reader broken in JmolData.jar; no issue with Jmol.jar or JSmol
  bug fix: PSE reader for Pymol 1.7.5 files may not set some models visible
  bug fix: PSE reader not processing (sele) and related selections
   
  new feature: set window width height
  new feature: set window \[width height\]
  new feature: set window \"xxx.png\"
   
  new feature: getProperty(\"shapeInfo.echo\")
  \-- a 1-length array (because all shapeInfo results are arrays
  \-- shapeInfo.echo\[0\] contains an associative array based on echo names
  \-- currently only include keys name, imageWidth, imageHeight, and imageFile
   
  \$ set echo myecho image \'http://noys3.weizmann.ac.il/a2jb/browse?sn=testSet/dna-a/pymol.png\'
  \$ print getProperty(\"shapeInfo.echo\[0\]\")
  {
  \"myecho\" :
  {
  \"imageFile\" : \"http://noys3.weizmann.ac.il/a2jb/browse?sn=testSet/dna-a/pymol.png\"
  \"imageHeight\" : 500
  \"imageWidth\" : 500
  \"name\" : \"myecho\"
  }
  }
   
  \-- idea is to allow access to image dimensions for any file image
  \-- for example, for a MacPyMOL session file, because those do not contain width and height information,
  we don\'t have the width and height we need to recreate the model window and associated Jmol image,
  but we can also read the associated PyMOL-generated PNG file and get the dimensions that way
   
  load \'xxxx.pse\' filter \'DORESIZE;DOCACHE\'
  set echo myecho image \'xxxx.png\'
  var a = getProperty(\'shapeInfo.echo\[0\].myecho\')
  set echo myecho off
  write PNGJ @{a.imageWidth} @{a.imageHeight} \'xxxx-jmol.png\'
   
  thus temporarily loading the PyMOL image just long enough to get its dimensions; not actually viewing it
   
  bug fix: SET nihResolverFormat does not work; using \"=\" does work.
  (There should be no reason to set this; Jmol is automatically changing those to \"https\".)
   
  JmolVersion=\"14.5.4_2016.04.14\"
   
  bug fix: Jmol 14.5.4_2016.04.13 will fail to read PDB files from scripts referencing http://www.rcsb.org/pdb/
  \-- does not affect http://www.rcsb.org/pdb/ligand
  \-- does not affect load =xxxx or load ==xxx
  \-- does not affect PNGJ files
  \-- only affects scripts that specifically reference that site (e.g. state scripts created prior to 4/13/2016)
   
  bug fix: selection of dssr elements using select within(dssr,\"pairs\[where\...\]\") is not working
  \-- example after fix:
  \$ load =1d66/dssr
  \$ print \_M.dssr.pairs.select(\"where bp=\'G-C\'\")\[1\]
  {
  \"DSSR\" : \"cW-W\"
  \"LW\" : \"cWW\"
  \"Saenger\" : \"19-XIX\"
  \"bp\" : \"G-C\"
  \"index\" : 3
  \"name\" : \"WC\"
  \"nt1\" : \"\|1\|D\|DG\|3\|\|\|\|\"
  \"nt2\" : \"\|1\|E\|DC\|36\|\|\|\|\"
  }
  \$ select within(dssr,\"pairs\")
  773 atoms selected
  \$ select within(dssr,\"pairs\[where bp=\'G-C\'\]\")
  243 atoms selected
  \$ select within(dssr,\"pairs\[where name=\'WC\'\]\")
  691 atoms selected
   
  \-- Note that this works because SELECT can find unit ids (\"\|1\|E\|DC\|36\|\|\|\|\") in any string.
  For example:
   
  \$ select \"\|1\|E\|DC\|36\|\|\|\|\"
  19 atoms selected
   
   
   
  JmolVersion=\"14.5.4_2016.04.13\"
   
  bug fix: JSmol cannot load RCSB ligand files
  bug fix: \"axis\" unintentionally made reserved word in \"14.4.4_2016.03.19\"
  bug fix: symop(\@1 \@2) broken
  bug fix: symop() taking default unitcell from \"current\" \-- should be that it
  REQUIRES a prefix \"{xxx}.\" if \@1 or \@2 are not indicated and there are
  multiple models (because it is a general function, not a script command).
   
  bug fix: models from PyMOL reader do not save atom colors in state when balls are colored
   
  new feature: \"\$isosurface1\".getProperty(\"atoms\")
  \-- returns atoms associated with this surface
  \-- for example, the atoms used to make a molecular surface
   
  \<\<\< above is not documented TODO
   
   
   
  new feature: show xxx /yyy
  \-- filters any SHOW command for lines containing \"yyy\" (case insensitive)
  \-- examples:
   
  \$ show symop/glide
  \$ show set/zoom
  \$ show state/draw
  \$ show file \"test.xyz\" /H
  \$ show file \"/remark 900\"
  \$ show variables/sym
   
  \<\<\< above is not documented TODO
   
   
  new feature: symop(3,\@3,\"atom\")
  \-- returns target atom or atoms
   
  new feature: show symop 3 \@3 \"atom\"
  \-- shows target atom or atoms
   
  \<\<\< above is not documented TODO
   
   
  JmolVersion=\"14.5.4_2016.04.11\"
   
  new feature: symop() options:
  symop(op)
  \-- returns the 4x4 matrix representation of this operator
  symop(op, atom)
  \-- returns the point generated by operator op on atom
  \-- op may be a positive or negative integer indictating the operation (or its reverse)
  to apply from the loaded space group \-- for example, symop(3, \@1) or symop(-4, {atomindex=16})
  \-- op may be a string such as \"x+1/2,1/2-y,z\" representing a specific generic operation
  symop(atom1, atom2)
  \-- returns the description of the first of possibly several operations that take atom1 to atom2, for example:
  \"2-fold screw axis\|translation: 1/2 0 0\"
  symop(atom1, atom2, n)
  \-- returns the description of the nth operation that takes atom1 to atom2
  symop(\...point\...)
  \-- any place an atom can be used in symop(), one can substitute an xyz coordinate.
  \-- for example, symop(\@1, {1/2 1/2 1/2})
  {atomset}.symop(\...)
  \-- when more than one model is loaded, prepending any symop function with an atom set specifies which
  atoms, space group, and unit cell are being referenced. For example, {2.1}.symop(5) operates only on
  atoms in the first model of the second loaded file, using the appropriate space group and unit cell.
  In this way, \"\@1\" will designate one atom only, provided only one model is showing (using the FRAME/MODEL command).
  If only one model has been loaded, there is no need to use this syntax; symop(\...) will do the same.
  symop(\..., outputType)
  \-- All uses of symop() and {atomset}.symop() can be extended using a final parameter that
  changes the default output described above to be something else. Options for outputType include:
   
  \"draw\" Returns the Jmol script illustrating this operation with DRAW commands.
   
  \$ print symop(3,\"draw\")
  draw ID draw\_\* delete
  draw ID draw_frame1X diameter 0.15{5.5172 1.9683 2.7802}{6.5172 1.9683 2.7802} color red
  \...
   
  \"full\" Returns the tab-separated Jones-Faithful string and descriptor for this operation.
   
  \$ print symop(3,\"full\")
  -x,-y,-z(mx,my,mz) Ci: 0 0 0
   
  \"lattice\" Returns the lattice type associated with the space group involving this operation.
   
  \"list\" Specifically when two atoms or points are specified, returns a string list of all operations
  taking the first to the second.
   
  \$ print symop(\@3,\@21,\"list\")
  5 x+1/2,-y+1/2,-z+1/2(-mx,my,mz) 2-fold screw axis\|translation: 1/2 0 0\|time-reversed
  7 -x+1/2,y+1/2,z+1/2(-mx,my,mz) n-glide plane\|translation: 0 1/2 1/2\|time-reversed
   
  Note that this string can be turned into a standard array using .lines.split(\"\\t\",true):
   
  \$ print symop(\@3,\@21,\"list\").lines.split(\"\\t\",true)
  \[
  5
  x+1/2,-y+1/2,-z+1/2(-mx,my,mz)
  2-fold screw axis\|translation: 1/2 0 0\|time-reversed
  \]
  \[
  7
  -x+1/2,y+1/2,z+1/2(-mx,my,mz)
  n-glide plane\|translation: 0 1/2 1/2\|time-reversed
  \]
   
  \"array\" Returns an associative array that contains critical information relating to this operation.
   
  \$ load =magndata/0.34
  \$ print symop(3,\"array\")
  {
  \"inversionCenter\" : {0.0 0.0 0.0}
  \"label\" : \"Ci: 0 0 0\"
  \"matrix\" :
  \[
  \[-1.0, 0.0, 0.0, 0.0\]
  \[0.0, -1.0, 0.0, 0.0\]
  \[0.0, 0.0, -1.0, 0.0\]
  \[0.0, 0.0, 0.0, 1.0\] \]
  \"timeReversal\" : 1
  \"xyz\" : \"-x,-y,-z(mx,my,mz)\"
  \"xyzOriginal\" : \"-x,-y,-z,m\"
  }
   
  In addition, all possible keys of this array may be used as well for outputType. These include:
   
  \"axisVector\", \"cartesianTranslation\", \"centeringVector\", \"fractionalTranslation\",
  \"inversionCenter\", \"label\", \"matrix\", \"plane\", \"rotationAngle\",
  \"timeReversal\", \"unitTranslation\", \"xyz\", and \"xyzOriginal\"
   
  Three of these that may be less than obvious are explained below:
   
  \"centeringVector\" For operations that are pure lattice translations, returns the vector
  for this centering in fractional coordinates.
   
  \"timeReversal\" This quantity is 0 for standard space groups. Magnetic space group
  operations also include the possibility of inversion of the spin
  along with any 3D symmetry operation. This inversion characteristic
  is referred to as \"time reversal\" and takes the value of 1 or -1.
   
  \"unitTranslation\" Symmetry operations involving two atoms may include an extra
  lattice translation if the two atoms are in different unit cells.
  This translation is above and beyond any fractional lattice centering
  that this operator incorporates for a face- or body-centered space group.
   
  \"id\" A number 1 - N, where N is the number of symmetry operators in the space group.
  (added in Jmol 14.29.17)
   
  \<\<\< above is not documented TODO
   
  new feature: show spacegroup/xxxxx
   
  \-- selects lines from a space group report similar to the way show state/xxxx works
  \-- example:
   
  load =ams/quartz 1
  show spacegroup/Class
   
  new feature: show/draw symop \@1 \@2
  \-- gives full list of matching symmetry operations
  \-- example:
   
  \$ load =magndata/1.23 {444 555 1} packed
  \$ show symop \@153 \@299
   
  1 x+2,y,z2(mx,my,mz) translation: 2 0 -2
  5 -x,-y,-z(mx,my,mz) Ci: 0 0 0
  11 x+2,-y,-z(-mx,my,mz) 2-fold screw axis\|translation: 2 0 0\|time-reversed
  15 -x,y,z2(-mx,my,mz) c-glide plane\|translation: 0 0 -2\|time-reversed
   
  new feature: show/draw symop \@1 \@2 n
  \-- shows or draws the nth symmetry operation relating atom 1 to atom 2
  \-- example:
   
  \$ load =magndata/1.23 {444 555 1} packed
  \$ show symop \@153 \@299 3
   
  11 x+2,-y,-z(-mx,my,mz) 2-fold screw axis\|translation: 2 0 0\|time-reversed
   
  new feature: print pointgroup(\"spacegroup\", \@1)
  \-- analyzes the point group (crystal class) of a crystal.
  \-- uses three irrational-coordinate points to generate all possible operators
  \-- creates a map with keys (somewhat variable depending upon axes present):
   
  C2
  C3
  Ci
  Cs
  S6
  detail
  distanceTolerance
  linearTolerance
  nAtoms
  nC2
  nC3
  nCi
  nCn
  nCs
  nS6
  nSn
  nTotal
  name
  points
  principalAxis
   
  new feature: draw SPACEGROUP
  \-- draws all operations in space group
   
  new feature: draw POINTGROUP SPACEGROUP
  \-- draws crystal class symmetry operations for a space group
  \-- uses point group style, with circular planes
   
  new feature: \@1.find(\"crystalClass\", pt)
  \-- generates a list of points based on a model\'s crystal class (point group)
  \-- uses \@1 just to find the unit cell and space group
  \-- optional pt is used as a generator (defaults to \@1)
  \-- example:
  load =ams/calcite 1
  x = \@3.find(\"crystalClass\")
  print pointgroup(x).name
  draw points \@x
  polyhedra ID p {0 0 0} to \@x
   
  bug fix: qchem reader fails to switch to spherical D/F basis for second structure
  bug fix: pointGroup secondary axis in yellow is too hard to see \-- using \"orange\" instead
   
  JmolVersion=\"14.5.4_2016.04.05b\"
   
  bug fix: unitcell primitive for A,B,C-centered lattices rotated 90 degrees from
  NRL standard (Michael Mehl, U.S. Naval Research Laboratory)
  bug fix: polyhedra COLLAPSED do not have correct normal vectors
  bug fix: assocArray.bin() should allow \"TRUE\" option
  bug fix: =mp/24972 not working after switch to https
   
  new feature: adds SHOW SMILES/bio and {\*}.find(\"SMILES/bio\") options:
  /bio Jmol bioSMILES with header and chain comments
  /bionocomments no chain comments (but still one header with comments)
  /bioatomcomments full atom comments
  /biocovalent indicates covalent S-S crosslinking using \":\" notation
  /biohbond indicates hydrogen bonds using \":\" notation
  /biounmatched allows unmatched rings
   
  new feature: SMILES/nonaromatic same as SMILES/noaromatic
   
  JmolVersion=\"14.5.4_2016.04.03\"
   
  bug fix: draw SCALE x.x symop has no effect; good to be able to scale down the arrow
  bug fix: draw symop can fail for second call
   
  JmolVersion=\"14.5.4_2016.03.31\"
   
  bug fix: load \$xxxx broken; http://cactus \--\> https://cactus
  bug fix: \_geom_bond_distance starting with \".\" halts CIF file reading
   
  JmolVersion=\"14.5.4_2016.03.29\"
   
  code: ru.po updated (Angel Herraez)
   
  bug fix: SMILES generator still broken in 14.4.4_2016.03.25
  bug fix: smiles1.find(\"SMILES\",smiles2) broken in 14.4.3_2016.03.06
   
  new feature: Polyhedra command allows for min and max radius
  \-- polyhedra 2.8 3.0 \@3
   
  bug fix: unitcell PRIMITIVE for rhombohedral groups not implemented
  bug fix: unitcell(\"primitive\",\"R\") not implemented
   
  bug fix: WRITE IMAGE with negative width or height should throw a Jmol ScriptException
  bug fix: draw \... \[x y\] does not position properly with antialias true
  bug fix: allow AXES TYPE \"\" or non-recognized to be same as \"abc\"
  bug fix: AXES TYPE \"ab\" should also be allowed when offset or center is set
  bug fix: labels should not change size when creating images of
  different size than screen when angstromsPerInch != 0.
  bug fix: if\...BREAK\|CONTINUE in unbracketed context does not properly
  place implicit END IF when TRUE clause is on next line
  AND next statement after that is another IF command:
  if (xxxx)
  break;
  if (yyyy)
  zzzz;
  becomes
  if (xxxx) {
  break;
  if (yyyy) {
  zzzz;
  }
  }
  instead of
  if (xxxx) {
  break;
  }
  if (yyyy) {
  zzzz;
  }
   
   
  JmolVersion=\"14.5.4_2016.03.25\"
   
  new feature: moveto AXIS \<a\|b\|c\|-a\|-b\|-c\> coupled with \<1\|2\|3\|4\>
  \-- indicates direction of axis (\"-a\" indicates \"a pointing away\")
  \-- and clockwise position 1(top left), 2(top right), 3(bottom right), and 4(bottom left)
  \-- defaults a == a1, b == -b1, c == c4
  \-- slight modification of what was released in 03.21
   
  bug fix: JavaScript Jmol.evaluateVar() does not properly escape JSON strings
  bug fix: SMILES generator broken in 03.23
   
  JmolVersion=\"14.5.4_2016.03.24b\"
   
   
  bug fix: axes/unitcell/boundbox appear 10x too thick after recalling from state
  \-- broken in JmolVersion=\"14.5.4_2016.03.21\"
   
  bug fix: polyhedra fix for overlapping face triangles
  bug fix: magnetic spin vector trail disappears when not vibrating
  bug fix: magnetic spin vector trail does not reset if set vectorscale \<n\> where \<n\> is less than current
   
  JmolVersion=\"14.5.4_2016.03.24\"
   
  bug fix: NCI requires stereochemistry to rings to be prior to a branch:
  C\\1(/C)=C\\C=C.C/1=C not C(/C)\\1=C\\C=C.C/1=C
   
  new feature: x.bin() method allows return of an array listing both the bound and the count
  \-- example:
   
  \$ print {\*}.bonds.length.all.bin(1,2,0.1,TRUE).format(\"json\")
  \[ \[ 1.0,10.0 \],\[ 1.1,0.0 \],\[ 1.2,0.0 \],\[ 1.3,3.0 \],\[ 1.4,2.0 \],\[ 1.5,1.0 \],\[ 1.6,0.0 \],\[ 1.7,0.0 \],\[ 1.8,0.0 \],\[ 1.9000001,0.0 \] \]
   
   
  new feature: load =magndata/1.1.37
  \-- links to the MAGNDATA database at http://webbdcrista1.ehu.es/magndata
  \-- \"magndata\", \"http://webbdcrista1.ehu.es/magndata/mcif/%FILE.mcif\",
   
  new feature: set vectorTrail n
  \-- adds a trail onto a modulating vector (as for an incommensurate magnetic spin)
  \-- n trails are made, typically in a fan-like pattern that trails the spinning vector
  load =magndata/1.1.37
  set vectortrace 20
  set vibrationperiod 2
  vibration on
   
  bug fix: saving a state after using LOAD \"\" (empty quotes)
  after pasting data directly into the application creates an unreadable state
   
  new feature: unitcell ON adds \#nnn (international table number) to cell description if found
   
  bug fix: {\*}.find(\"CHEMICAL\",\"NAMES\") only reports one name.
   
  code: more efficient identifying space group
   
  JmolVersion=\"14.5.4_2016.03.22\"
   
  bug fix: select picking invertstereo broken
   
  bug fix: unitcell PRIMITIVE does not work as reported 3/21
  bug fix: unitcell(\"conventional\",\"F\") does not work
  bug fix: crystal systems with translational symmetry may have duplication of symmetry operators
   
   
  JmolVersion=\"14.5.4_2016.03.21\"
   
  new feature: axes OFFSET x.x
  \-- applies offset of x.x in fractional coordinates in each axis direction
  \-- AXES OFFSET -0.1 same as AXES CENTER {-0.1 -0.1 -0.1/1}
   
  new feature: expanded unitcell() function
  \-- adds additional types: \"A\", \"B\", \"C\", \"I\", \"F\"
  \-- default is the lattice type of the model\'s space group
  \-- not just cubic; \"BCC\" is converted to \"I\"
  \-- for example:
   
  load =ams/silicon 15 packed // Cmca
  draw id \"uc\" diameter 0.1 unitcell mesh nofill color black
  unitcell @{unitcell(\"primitive\")}
  color unitcell red
  unitcell 0.1
  axes unitcell
  axes on
   
  new feature: expanded UNITCELL command to include PRIMITIVE option for any space group
   
  bug fix: SMILES matcher not allowing azulene to be aromatic
   
  bug fix: OpenSMILES matcher not allowing non-chemist Hueckel 4+2 interpretation
   
  bug fix: SMILES generator not adding \"-\" for biphenyl Ar-Ar bond
   
  bug fix: set picking invertSTEREO does not work on open-ring systems
   
  bug fix: SMARTS \[R\] matching all atoms
   
  bug fix: dashed lines not visible in measurements, unit cells, and axes
   
  bug fix: axes 0.01 produces thick 20-pixel-wide lines
  \-- solution was to drop that to 0.001 for this effect
   
  JmolVersion=\"14.5.4_2016.03.14\"
   
  bug fix: Polyhedra with verticies that are also centers of polyhedra for atoms that were visible
  but are no longer visible do not update screen positions properly
   
  JmolVersion=\"14.5.4_2016.03.13\"
   
  new feature: polyhedra POINTS x.y
  \-- adds variable size spherical points at corners of polyhedra
  \-- color is that of element, or black
   
  new feature: show SMILES/xxxx
  \-- xxxx = open, strict, openstrict, mmff94
   
  new feature: show chemical NAME
  \-- singular \"name\" gives just the first name; \"names\" gives full list
   
  new feature: full implementation of OpenSMILES aromatic model
   
  TODO: DOCUMENT\--\>\>\>
   
  new feature: {\*}.find(\"SMILES/open\")
  \-- generates OpenSMILES string for selected atoms
  \-- applies OpenSMILES aromaticity rules for 5-, 6-, and 7-membered rings
  \-- not chemical \-- allows exocyclic c=C bonds and \[nH\] in 6-membered rings
  \-- also adds atom class if property_atomClass is nonzero
  \-- for example:
   
  \$ load \$2-butanol
  \$ \@2.property_atomclass=2
  \$ \@3.property_atomclass=3
  \$ \@5.property_atomclass=5
  \$ print {\*}.find(\"smiles/open\")
   
  C\[C\@H:2\](\[OH:5\])\[CH2:3\]C
   
  new feature: /open option for smiles.find(\"SMILES\", pattern)
  \-- applies OpenSMILES model of aromaticity
  \-- finds aromaticity-normalized pattern \"in\" aromaticity-normalized smiles
  \-- can be after SMILES or as beginning of pattern
  \$ print \"OC1=CC(N)=CC=C1\".find(\"SMILES\",\"NC1=CC(O)=CC=C1\")
  0
  \$ print \"OC1=CC(N)=CC=C1\".find(\"SMILES/open\",\"NC1=CC(O)=CC=C1\")
  8
  \$ print \"OC1=CC(N)=CC=C1\".find(\"SMILES\",\"/open/NC1=CC(O)=CC=C1\")
  8
   
  new feature: compare(\"smile1\",\"/open/smiles2\")
  \-- applies OpenSMILES model of aromaticity
  \-- checks for match of atom class if present (default value 0 matches \"not present\")
  \-- does aromaticity normalization on both strings
  \$ print compare(\"OC1=CC(N)=CC=C1\", \"NC1=CC(O)=CC=C1\", \"isomer\")
  CONSTITUTIONAL ISOMERS
  \$ print compare(\"OC1=CC(N)=CC=C1\", \"/open/NC1=CC(O)=CC=C1\", \"isomer\")
  IDENTICAL
   
  new feature: {\*}.find(\"SMILES/strict\")
  \-- generates OpenSMILES string for selected atoms
  \-- applies standard Hueckel aromaticity rules for 5-, 6-, and 7-membered rings
  \-- does not allow exocyclic c=C bonds or \[nH\] in 6-membered rings
  \-- does not create atom classes
  \-- also for compare() and search()
   
  new feature: {\*}.find(\"SMILES/open strict\")
  \-- same as just /strict, but also generates atom classes if present as property_atomClass
  \-- also for compare() and search()
   
  new feature: {\*}.find(\"SMILES/mmff94\")
  \-- applies a very STRICT, chemically meaningful Hueckel 4+2 Rule
  \-- adds allowance for only a 1-electron contribution to 6-membered rings (three double bonds)
  \-- also for compare() and search()
   
  new feature: optional processing of OpenSMILES \[CH2:002\] \":\<n\>\" atom class.
  \-- positive integer value only
  \-- checks the atom property property_atomclass
  \-- for SMARTS, \[:0\] means \"without an atomclass\"
  \-- for SMARTS, \[!:0\] means \"any non-zero atomclass\"
  \-- for SMARTS, same as \[\$(select property_atomclass=n)\]
  \-- only enabled with Jmol SMILES directive \"/open/\"; otherwise ignored
  \-- for example:
   
  \$ load \$2-butanol
  \$ show smiles
   
  C\[C\@H\](O)CC
   
  \$ \@2.property_atomclass=2
  \$ \@3.property_atomclass=3
  \$ \@5.property_atomclass=5
   
  \$ select \*
  15 atoms selected
  \$ select on search(\"/open/\[:3\]\")
  1 atoms selected
  \$ select on search(\"/open/\[!:3\]\")
  14 atoms selected
  \$ select on search(\"/open/\[:0\]\")
  12 atoms selected
  \$ select on search(\"/open/\[!:0\]\")
  3 atoms selected
  \$ select on search(\"/open/\[!:3 & !:0\]\")
  2 atoms selected
   
  new feature: UNITCELL TRANSFORM \@m4x4
  \-- direct 4x4 matrix transformation of a unit cell
   
  new feature: calculate symmetry polyhedra {atomset}
  \-- selectively calculates polyhedra.
  \-- for example: calculate symmetry polyhedra {polyhedra(4)}
   
  new feature: calculate symmetry polyhedra id
  \-- selectively calculates polyhedra for a given ID.
  \-- for example: calculate symmetry polyhedra \"poly1\"
   
   
  new feature: atom set can be specified in polyhedra() function:
  \-- print {2.1}.polyhedra(3)
  \-- print {2.1}.polyhedra(\"\....polySMILES string\...\")
   
  TODO: document \<\<\<\-\-\-\-\-\-\-\-\--
   
  new feature: WRITE MOL67 xxx.mol
  \-- writes MOL format with bonds of type 6 or 7 (aromatic single/double; rarely significant)
   
   
  bug fix: SMILES should not be returned with comments for internal processing or sending to PubChem or others
   
  bug fix: SHOW chemical SMILES can be off because it was using the name, not the SMILES string
  \-- sometimes - e.g. \"menthol\" - the name has no chirality, but the structure does (of course).
   
  bug fix: Jmol 14.3.16_2015.09.15 broke first-match-only flag in SMILES mapping
   
  bug fix: POLYHEDRA when selection halos are on, all have edges
   
  bug fix: moving of polyhedron will fail if corner of polyhedron is an atom
   
  bug fix: macro functions cannot be used later in same script as a MACRO command
  \-- presence of MACRO command now removes check for unknown command name exception
   
  bug fix: Tripos MOL2 reader does not read element symbols properly
   
  bug fix: default write MOL file should not indicate aromatic bond types 6 and 7
  \-- corrects the fact that these bonds are reserved for queries
  \-- only affects cases where that bond type has been set (after calculate aromatic or loading of ligand CIF files
   
   
  JmolVersion=\"14.5.4_2016.03.08\"
   
  bug fix: OpenSMILES even-atom cumulene stereochemistry not implemented
  \-- examples (reporting \"DIASTEREOMERS\")
  print compare(\"F/C=C=C=C/F\",\"F/C=C=C=C\\\\F\",\"isomer\")
  load \$F-C=C=C=C-F;print compare(\"F/C=C=C=C\\\\F\",{1.1},\"isomer\")
   
  bug fix: SMILES generator unnecessarily over-expressing double-bond / and \\.
   
  new feature: (JSmol) standard InChI generator (see inchi.htm, inchi/\*)
  \-- JavaScript library for generation of InChIs
  \-- runs completely in JavaScript
  \-- equivalent to SHOW CHEMICAL stdinchi
  \-- about 900 KB
   
   
  JmolVersion=\"14.5.3_2016.03.06\"
   
  bug fix: Inconsistent use of \"DIASTEREOMERS\" (preferred) and \"DIASTERIOMERS\" (incorrect)
   
  JmolVersion=\"14.5.3_2016.03.05\"
   
  bug fix: SMILES TB trigonal bipyramidal stereochemistry not functional
  bug fix: SMILES \[\@TBn\] not recognizing n \> 2
   
  bug fix: SMILES OH octahedral stereochemistry error
  bug fix: SMILES \[\@OHn\] not recognizing n \> 2
   
  bug fix: SMILES SP square planar stereochemistry will report ENANTIOMERS rather than DIASTEREOMERS
   
  JmolVersion=\"14.5.3_2016.03.03b\"
   
  bug fix: CIF reader \_atom_site_cartn_x incompatible with \_geom_bond
  \-- this fix now allows Jmol to read very simple CIF files that are equivalent to unlimited-atom MOL files
  \-- \_ccdc_geom_bond_type is not required, defaulting to S
  \-- \_ccdc_geom_bond_types include S, D, T, Q (quadruple), and A (aromatic)
   
  data_icosahedron
  loop\_
  \_atom_site_label
  \_atom_site_Cartn_x
  \_atom_site_Cartn_y
  \_atom_site_Cartn_z
  C01 0.0000000000 0.0000000000 9.5105651630
  C02 8.5065080835 0.0000000000 4.2532540418
  C03 2.6286555606 8.0901699437 4.2532540418
  C04 -6.8819096024 5.0000000000 4.2532540418
  C05 -6.8819096024 -5.0000000000 4.2532540418
  C06 2.6286555606 -8.0901699437 4.2532540418
  C07 6.8819096024 5.0000000000 -4.2532540418
  C08 -2.6286555606 8.0901699437 -4.2532540418
  C09 -8.5065080835 0.0000000000 -4.2532540418
  C10 -2.6286555606 -8.0901699437 -4.2532540418
  C11 6.8819096024 -5.0000000000 -4.2532540418
  C12 0.0000000000 0.0000000000 -9.5105651630
  loop\_
  \_geom_bond_atom_site_label_1
  \_geom_bond_atom_site_label_2
  \_ccdc_geom_bond_type
  C01 C02 S
  C01 C03 S
  C01 C04 S
  C01 C05 S
  C01 C06 S
  C02 C03 S
  C03 C04 S
  C04 C05 S
  C05 C06 S
  \...etc\...
   
   
  JmolVersion=\"14.5.3_2016.03.03\"
   
  bug fix: after SET echo ALL, background echo \... changes text color, not background color
   
  JmolVersion=\"14.5.3_2016.03.02\"
   
  bug fix: JavaScript reference to j2s for working gif does not recognize Info.j2sPath
   
  JmolVersion=\"14.5.3_2016.02.28\"
   
  bug fix: cyclic peptides do not complete loop for cartoons, backbone, etc. (1SFI)
   
  JmolVersion=\"14.5.3_2016.02.27\"
   
  bug fix: \[function:\"yyy\",Function:\"zzz\"\] fails to retain key capitalization after first entry for special names
  bug fix: (JavaScript only) polyhedra not saved in state
  bug fix: (Applet) broken image in coverImage
  bug fix: polyhedra DELETE can crash Jmol if polyhedra are not colored
   
  JmolVersion=\"14.5.3_2016.02.17\"
   
  bug fix: slab/depth SET do not behave properly
  bug fix: select VISIBLE is not properly set based on slab/depth SET
   
  bug fix: \_GEOM_BOND reading in CIF files nonfunctional.
  \-- broken in 13.3.4_dev_2013.08.21
  \-- result is that between 8/21/2013 and 2/15/2016 the CIF reader
  would not recognize \_GEOM_BOND and so also not create whole molecules
  as it was designed to do when those are present.
  \-- no impact on states created within this version range
  \-- no impact on mmCIF reader
  \-- only impact is upon Materials Studio-generated files such as
  http://www.rsc.org/suppdata/cc/c2/c2cc34714h/c2cc34714h.txt
  (supplemental mat. for http://pubs.rsc.org/en/Content/ArticleLanding/2012/CC/c2cc34714h)
  See Jmol list discussion: https://sourceforge.net/p/jmol/mailman/message/31308577/
   
   
  JmolVersion=\"14.5.2_2016.02.14\"
   
  FEATURE CHANGE: JSmol default for Info.\_disableInitialConsole changed to true
  \-- no longer necessary with JSmol_spinner.gif
   
  new feature: j2s/img/JSmol_spinner.gif implemented (Angel Herraez)
  \-- as default for Info.\_appletLoadingImage
  \-- use Info.\_appletLoadingImage = \"none\" to disable
   
  new feature: j2s/img/cursor_wait.gif animation implemented
   
  bug fix: STRUCTURE statement (utilized in RESTORE STRUCTURE) broken
  \-- broken in Jmol 14.4.0_2015.10.30
   
  bug fix: EBI assembly CIF files that are multi-model files will be by chain, not by model.
  \-- result was that each chain became a new model
  \-- for example: see http://www.ebi.ac.uk/pdbe/static/entry/download/2lev-assembly-1.cif.gz
   
  bug fix: XmlMolProReader does not recognize FILTER \"NOMO\"
   
  bug fix: JSmol has never shown cursors
   
  JmolVersion=\"14.5.2_2016.02.09\"
   
  new feature: invertselected ATOMS {ring atoms to invert}
  \-- inverts ring stereochemistry
  \-- requires prior selection of all atoms to be involved in the inversion
   
  bug fix: SMARTS pattern \[ALA.\*\] not working without biological polymer type indication
  bug fix: SMARTS pattern \[r500\] not working outside of MINIMIZE
   
   
  JmolVersion=\"14.5.2_2016.02.06\"
   
  new feature: isosurface BACKSHELL
  \-- displays just the back side of an isosurface
  \-- works by reversing the normals, then showing front only
  \-- similar to isosurface slab 50, but better if object is far from spherical
  \-- works with PMESH, MO, CONTACT as well
  \-- reverted using isosurface NOBACKSHELL
   
  new feature: isosurface \"\*xxxx\"
  \-- accesses EBI test site for ED maps at http://wwwdev.ebi.ac.uk/pdbe/coordinates/files/%file.ccp4
  \-- uses default sigma 1.0
   
  new feature: isosurface \"\*\*xxxx\"
  \-- accesses EBI test site for ED difference maps at http://wwwdev.ebi.ac.uk/pdbe/coordinates/files/%file_diff.ccp4
  \-- uses default sigma 3.0
   
  bug fix: JSmol not identifying .ccp4 file extension as binary
  bug fix: isosurface \"==xxxx\" not setting default omap cutoff and sigma 3.0
  bug fix: small MRC map files mistaken for DELPHI files.
  bug fix: MRC/CCP4 surface/map files still sometimes inside out.
   
  JmolVersion=\"14.5.2_2016.02.05\"
   
   
  bug fix: MRC/CCP4 surface/map files sometimes inside out.
   
  bug fix: LOAD \$benzene; SHOW smiles should give c1ccccc1 not c1=cc=cc=c1
   
  JmolVersion=\"14.5.2_2016.02.04\"
   
  bug fix: JVXL files saved from models that involve full model rotate/translateSelected
  do not get restored properly.
   
  bug fix: molecular orbitals do not move with atoms
  when full molecule is moved using rotateSelected or translateSelected
   
  code: better loading of surfaces \-- no longer requires javajs.util.XmlUtil
  code: removal of unnecessary api interfaces MinimizerInterface, VolumeDataInterface, QuantumPlaneCalculationInterface, MOCalculationInterface, MepCalculationInterface
   
  JmolVersion=\"14.5.2_2016.02.03\"
   
  bug fix: IboView/Molpro XML reader validated for multi-molecule XML files
  \-- to concatenate Molpro XML files, you must supply a new root tag as well as
  remove all \<?\...?\> directives.
  \-- DOS CMD file example:
   
  catxml.bat ibo\*.xml test.xml
   
  where catxml.bat is:
   
  copy /b %1 \_temp
  echo \^\<OUTER\^\> \> %2
  type \_temp \| find /V \"\<?\" \>\> %2
  echo \^\</OUTER\^\> \>\> %2
   
   
   
  JmolVersion=\"14.5.1_2016.02.01\"
   
  bug fix: IboView/Molpro XML Reader validated for reading orbitals
   
  code: new abstract reader XmlMOReader
   
   
  JmolVersion=\"14.5.1_2016.01.28\"
   
  bug fix: MOs need to move with atoms and be restored from state properly
  after use of ROTATESELECTED.
  \-- note that fix for 14.4 does not include state saving, as that would break previous subversions
   
  code: JmolZipUtilities interface removed
  code: JmolBinary reduced to just all Spartan-related methods
   
  JmolVersion=\"14.5.1_2016.01.25\"
   
  bug fix: Spartan file reader not working properly after MacSpartan -\> Spartan14 upgrade
   
  JmolVersion=\"14.5.1_2016.01.16\"
   
  bug fix: mol, xyz readers not reporting model name like other readers
   
  new feature: variable \_versionDate
  \$ show \_versionDate
  \_versionDate = \"14.4.1_2016.01.16 2016-01-15 17:25\"
   
   
  new feature: x = pointgroup(\[array of points\],center)
  \-- center is optional, defaulting to average of the points
  \-- returns a map:
  pts = \[ {-1.0132 0.585 0.0012999999},{1.0132 0.585 0.0012999999},{0.0 -1.17 0.0012999999} \]
  print pointgroup(pts,{0 0 0})
  {
  \"C2\" :
  \[
  {0.8660127 -0.50001717 0.0022222984}
  {-0.8660127 -0.50001717 0.0022222984}
  {0.0 0.99999756 0.002222217}
  \]
  \"C3\" :
  \[
  {0.0019245904 -0.0011111083 -0.99999756}
  \]
  \"Cs\" :
  \[
  {0.0019245904 -0.0011111085 -0.99999756}
  {-0.49998164 -0.866036 0.0}
  {0.49998164 -0.866036 0.0}
  {1.0 0.0 0.0}
  \]
  \"S3\" :
  \[
  {0.0019245904 -0.0011111083 -0.99999756}
  \]
  \"center\" : {0.0 0.0 0.0}
  \"detail\" : \"\# 3 atoms;\"
  \"distanceTolerance\" : 0.2
  \"linearTolerance\" : 8.0
  \"nAtoms\" : 3
  \"nC2\" : 3
  \"nC3\" : 1
  \"nCi\" : 0
  \"nCn\" : 4
  \"nCs\" : 4
  \"nS3\" : 1
  \"nSn\" : 1
  \"nTotal\" : 12
  \"name\" : \"D3h\"
  \"principalAxis\" : {0.0019245904 -0.0011111083 -0.99999756}
  \"principalPlane\" : {0.0019245904 -0.0011111085 -0.99999756}
  }
   
  code: polyhedra, pointgroup, load =ams/, load \"xxxx\#\_DOCACHE\_\" features from 14.5 added to 14.4
   
  JmolVersion=\"14.5.1_2016.01.15\"
   
  bug fix: d = \[start:1,end:10\] fails due to reserved word \"end\" (also \"select\", \"case\", \"default\", \"if\", \"for\", etc.)
  bug fix: color \"chain\" (with quotes) should work, allowing for x=\"chain\"; color \@x
  bug fix: inappropriate use of REGEX in \[\"a\",\"b\"\].find(\"x\")
  bug fix: \".xxx\" should be allowed as a math continuation:
   
  print script(\"show spacegroup all\")
  .split()
  .find(\"Hall symbol:\")
   
  JmolVersion=\"14.5.1_2016.01.09\"
   
  code: (JavaScript) refactoring to allow faster, cleaner load for biomodels
   
  JmolVersion=\"14.5.1_2016.01.08\"
   
  bug fix: labels, echos, and measurements improperly shaded when z-shaded with nonblack background
  bug fix: rendering error when set zshade followed by set antialiasdisplay
   
  code: (JavaScript) refactoring to reduce extraneous file download
   
  JmolVersion=\"14.5.1_2016.01.06\"
   
  bug fix: labels, echos, and measurements disappear when z-shaded
   
  JmolVersion=\"14.5.1_2016.01.04\"
   
  bug fix: (JvxlReader) Jmol 12 mapped isosurface jvxl files do not show mapped color
  bug fix: setting default label properties using select none;\.... fails
  bug fix: setting cartoons on for phosphorus-only polymers fails
  bug fix: undocumented model-based draw \[array of points\] broken
  \-- points only
  \-- selects from visible frames (frame \*, for example)
  \-- load cyclohexane_movie.xyz; frame \*; draw @{{C5}.split().sub({1,0,0})
   
  JmolVersion=\"14.5.1_2016.01.01\"
   
  bug fix: file dropping of JVXL files does not work
  bug fix: Mesh capper not working for multiple cuts due to unclosed surface cut
  \-- for example: load maleic.cif 1;select on atomindex=6;lcaocartoon scale 1.0 CAP unitcell \"cpk\"
  bug fix: Escape.e(P4) returns value for Escape.e(T3) \-- only affects SurfaceTool
  bug fix: (JSmol only) Java return (int) fValue(x); will return \"NaN\" instead of \"0\" for x NaN
  \-- JSmol script 0 + \"test\" will print \"NaN\" rather than \"0\"
   
  JmolVersion=\"14.5.1_2015.12.23b\"
   
  bug fix: JavaScript error reporting uses alert() instead of just setting the error message
  bug fix: PyMOL 1.8 PSE files cannot be read because of missing settings
   
  code: more efficient loading of PyMOL .pse session files
   
  JmolVersion=\"14.5.1_2015.12.23\"
   
  bug fix: PyMOL 1.8 PSE files cannot be read
  bug fix: dots broken when colored none
  bug fix: color cartoons red blue not saved in state
  bug fix: color cartoons red blue flipping red/blue in sheets
   
  JmolVersion=\"14.5.1_2015.12.21\"
   
  bug fix: color \[0xffffff\] should not be case-sensitive \-- \[0Xffffff\] should be OK
  bug fix: set spin fps \... fails
   
  JmolVersion=\"14.5.1_2015.12.20\"
   
  code: (JavaScript) adding use of array.slice and implementing Java byte\[\] as JavaScript Int8Array()
   
  bug fix: array handling for labels very inefficient
  bug fix: y = javascript(\"x\") only creates string equivalent of x, not actual numerical/object values
  bug fix: y = javascript(\"x\") draws \"x\" from wrapped anonymous function using eval() instead of global context using window.eval()
   
  JmolVersion=\"14.5.1_2015.12.14\"
   
  bug fix: JSmol (JSmolCore.js) check for MS Edge browser, which does not support dataURI
   
  JmolVersion=\"14.5.0_2015.12.13\"
   
   
  new feature: \"\#\_DOCACHE\_\" suffix for file name loading tells Jmol to insert full structure into any state
  \-- allows SPT files to preserve the original file (as in all PNGJ files)
  \-- for example:
  load caffeine.xyz\#\_DOCACHE\_
  show state
  \...
  function \_setFileState() {
  DATA \"file_caffeine.xyz\#\_DOCACHE\_\"
  24
   
  N 1.31200 -1.04790 0.00250
  C 2.24650 -2.17620 0.00310
  \...
  H -4.16720 -0.83950 0.51680
  END \"file_caffeine.xyz\#\_DOCACHE\_\";
  \...
  load /\*file\*/\"c:/jmol-dev/bobtest/caffeine.xyz\#\_DOCACHE\_\";
  }
  \...
  \-- repeated calls to caffeine.xyz\#\_DOCACHE\_ use the cached version, not the actual file
  \-- calls to caffeine.xyz still ignore the cache.
  \-- also addded to Jmol 14.4.0, but left undocumented
   
   
  new feature: load =ams loads data from American Mineralogist Crystal Structure Database
  \-- many thanks given to Robert Downs and Alex Pires for enabling this functionality.
  \-- fetches data from http://rruff.geo.arizona.edu/AMS
  \-- employs \"\#\_DOCACHE\_\" flag because some of these data files may change after database maintenance
  \-- three modes. Only the first, using \_database_code_amcsd, is guaranteed to be stable over time,
  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
