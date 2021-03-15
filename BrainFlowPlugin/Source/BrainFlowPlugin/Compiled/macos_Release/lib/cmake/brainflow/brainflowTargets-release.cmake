#----------------------------------------------------------------
# Generated CMake target import file for configuration "Release".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "brainflow::BoardController" for configuration "Release"
set_property(TARGET brainflow::BoardController APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::BoardController PROPERTIES
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libBoardController.dylib"
  IMPORTED_SONAME_RELEASE "@rpath/libBoardController.dylib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::BoardController )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::BoardController "${_IMPORT_PREFIX}/lib/libBoardController.dylib" )

# Import target "brainflow::DataHandler" for configuration "Release"
set_property(TARGET brainflow::DataHandler APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::DataHandler PROPERTIES
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libDataHandler.dylib"
  IMPORTED_SONAME_RELEASE "@rpath/libDataHandler.dylib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DataHandler )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DataHandler "${_IMPORT_PREFIX}/lib/libDataHandler.dylib" )

# Import target "brainflow::DSPFilters" for configuration "Release"
set_property(TARGET brainflow::DSPFilters APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::DSPFilters PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_RELEASE "CXX"
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libDSPFilters.a"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DSPFilters )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DSPFilters "${_IMPORT_PREFIX}/lib/libDSPFilters.a" )

# Import target "brainflow::WaveLib" for configuration "Release"
set_property(TARGET brainflow::WaveLib APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::WaveLib PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_RELEASE "CXX"
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libWaveLib.a"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::WaveLib )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::WaveLib "${_IMPORT_PREFIX}/lib/libWaveLib.a" )

# Import target "brainflow::GanglionLib" for configuration "Release"
set_property(TARGET brainflow::GanglionLib APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::GanglionLib PROPERTIES
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libGanglionLib.dylib"
  IMPORTED_SONAME_RELEASE "@rpath/libGanglionLib.dylib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::GanglionLib )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::GanglionLib "${_IMPORT_PREFIX}/lib/libGanglionLib.dylib" )

# Import target "brainflow::MLModule" for configuration "Release"
set_property(TARGET brainflow::MLModule APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::MLModule PROPERTIES
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libMLModule.dylib"
  IMPORTED_SONAME_RELEASE "@rpath/libMLModule.dylib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::MLModule )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::MLModule "${_IMPORT_PREFIX}/lib/libMLModule.dylib" )

# Import target "brainflow::Brainflow" for configuration "Release"
set_property(TARGET brainflow::Brainflow APPEND PROPERTY IMPORTED_CONFIGURATIONS RELEASE)
set_target_properties(brainflow::Brainflow PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_RELEASE "CXX"
  IMPORTED_LOCATION_RELEASE "${_IMPORT_PREFIX}/lib/libBrainflow.a"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::Brainflow )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::Brainflow "${_IMPORT_PREFIX}/lib/libBrainflow.a" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
