#----------------------------------------------------------------
# Generated CMake target import file for configuration "Debug".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "brainflow::BoardController" for configuration "Debug"
set_property(TARGET brainflow::BoardController APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::BoardController PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/BoardController.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/BoardController.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::BoardController )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::BoardController "${_IMPORT_PREFIX}/lib/BoardController.lib" "${_IMPORT_PREFIX}/lib/BoardController.dll" )

# Import target "brainflow::DataHandler" for configuration "Debug"
set_property(TARGET brainflow::DataHandler APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::DataHandler PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/DataHandler.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/DataHandler.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DataHandler )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DataHandler "${_IMPORT_PREFIX}/lib/DataHandler.lib" "${_IMPORT_PREFIX}/lib/DataHandler.dll" )

# Import target "brainflow::DSPFilters" for configuration "Debug"
set_property(TARGET brainflow::DSPFilters APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::DSPFilters PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/DSPFilters.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DSPFilters )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DSPFilters "${_IMPORT_PREFIX}/lib/DSPFilters.lib" )

# Import target "brainflow::WaveLib" for configuration "Debug"
set_property(TARGET brainflow::WaveLib APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::WaveLib PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/WaveLib.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::WaveLib )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::WaveLib "${_IMPORT_PREFIX}/lib/WaveLib.lib" )

# Import target "brainflow::GanglionLib" for configuration "Debug"
set_property(TARGET brainflow::GanglionLib APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::GanglionLib PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/GanglionLib.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/GanglionLib.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::GanglionLib )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::GanglionLib "${_IMPORT_PREFIX}/lib/GanglionLib.lib" "${_IMPORT_PREFIX}/lib/GanglionLib.dll" )

# Import target "brainflow::MLModule" for configuration "Debug"
set_property(TARGET brainflow::MLModule APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::MLModule PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/MLModule.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/MLModule.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::MLModule )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::MLModule "${_IMPORT_PREFIX}/lib/MLModule.lib" "${_IMPORT_PREFIX}/lib/MLModule.dll" )

# Import target "brainflow::Brainflow" for configuration "Debug"
set_property(TARGET brainflow::Brainflow APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::Brainflow PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/Brainflow.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::Brainflow )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::Brainflow "${_IMPORT_PREFIX}/lib/Brainflow.lib" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
