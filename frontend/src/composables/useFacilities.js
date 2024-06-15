import { ref, inject } from 'vue';

export function useFacilities() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const facilities = ref([]);
    const facility = ref(null);
    const error = ref(null);

    const fetchFacilities = async () => {
        try {
            const response = await apiClient.get('/facility');
            facilities.value = response.data;
        } catch (err) {
            console.error("API error", err);
            error.value = err;
        }
    };

    const fetchFacility = async (id) => {
        try {
            const response = await apiClient.get(`/Facility/${id}`);
            facility.value = response.data;
        } catch (err) {
            error.value = err;
        }
    };

    return {
        facilities,
        facility,
        error,
        fetchFacilities,
        fetchFacility,
    };
}