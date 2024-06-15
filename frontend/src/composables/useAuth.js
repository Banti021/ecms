import { ref, inject } from 'vue';
import { useAuthState } from './useAuthState';
import router from '../router';

export function useAuth() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const { isAuthenticated } = useAuthState();
    const user = ref(null);
    const error = ref(null);

    const login = async (credentials) => {
        try {
            const response = await apiClient.post('/Auth/login', credentials);
            user.value = response.data;
            error.value = null;
            isAuthenticated.value = true;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error("API error", err);
            error.value = err.response ? err.response.data : err.message;
        }
    };

    const register = async (userData) => {
        try {
            const response = await apiClient.post('/Auth/register', userData);
            user.value = response.data;
            error.value = null;
            isAuthenticated.value = true;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error("API error", err);
            error.value = err.response ? err.response.data : err.message;
        }
    };

    const logout = () => {
        user.value = null;
        isAuthenticated.value = false;
        router.push({ name: 'Login' });
    };

    return {
        user,
        error,
        login,
        register,
        logout,
        isAuthenticated
    };
}
