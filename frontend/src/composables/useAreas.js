import { ref, inject } from 'vue';

export function useAreas() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const areas = ref([]);
    const areasForFacility = ref([]);
    const area = ref(null);
    const error = ref(null);

    const fetchAreas = async () => {
        try {
            const response = await apiClient.get('/Area');
            areas.value = response.data;
        } catch (err) {
            console.error("API error", err);
            error.value = err;
        }
    }

    const fetchArea = async (id) => {
        try {
            const response = await apiClient.get(`/Area/${id}`);
            area.value = response.data;
        } catch (err) {
            error.value = err;
        }
    };

    const fetchAreasForFacility = async (facilityId) => {
        try {
            const response = await apiClient.get(`/Area/facility/${facilityId}`);
            areasForFacility.value = response.data;
        } catch (err) {
            console.error("API error", err);
            error.value = err;
        }
    };

    return {
        areas,
        areasForFacility,
        area,
        error,
        fetchAreas,
        fetchAreasForFacility,
        fetchArea,
    };
}
