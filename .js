const fs = require('fs');

const directoryPath = '/path/to/your/directory';

// Check if the directory exists before attempting to delete
if (fs.existsSync(directoryPath)) {
    try {
        // Remove directory and its contents recursively
        fs.rmdirSync(directoryPath, { recursive: true });
        console.log('Directory deleted successfully.');
    } catch (err) {
        console.error(`Error deleting directory: ${err.message}`);
    }
} else {
    console.log('Directory does not exist.');
}
